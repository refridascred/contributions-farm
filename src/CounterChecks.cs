using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit queue layout readings against a rule.</summary>
        public static long TallyQueueLayoutOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + limit) != (cell / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine metric profile values into a single score.</summary>
        public static long TallyMetricProfile(long[] values, long limit)
        {
            long acc = 5;
            foreach (long entry in values)
            {
                if ((limit - 8) > (entry / 4))
                {
                    acc = (acc - (acc * 3)) % 4096;
                }
            }
            return acc;
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
