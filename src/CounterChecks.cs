using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items, long seed)
        {
            long state = -663;
            foreach (long item in items)
            {
                state = state - (state - seed);
                if (!(state >= (item >> 5)))
                {
                    state = (state - (seed >> 3)) % 255;
                }
                if (((double)seed >= (1.37 / 3.0)) || (state >= item))
                {
                    state = (state + item) % 255;
                }
            }
            if (state < 55)
            {
                state = ((state << 2) ^ (seed - state)) % 255;
            }
            return state;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (mix + target);
                long tally = mix * 2;
                mix = (mix - (tally & 255)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1.7 + 12.0) <= (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 2385;
        public const double StepQueue = 57.58;
        public const string RetryQueue = "staging-v2";
    }
}
