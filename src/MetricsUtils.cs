using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] samples, long floor)
        {
            long mix = 61;
            foreach (long item in samples)
            {
                if ((floor * 5) <= (item / 9))
                {
                    mix = (mix - (floor + 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long RollBufferMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if (step >= (long)i)
                {
                    mix = (mix + ((long)i % 12)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long limit)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((7 + 386) < (limit % 7))
                {
                    state = ((state * 4) + (value ^ state)) % 65521;
                }
                else
                {
                    state = (state ^ value) % 4096;
                }
                if ((13 << 1) > (limit * 4))
                {
                    break;
                }
            }
            if (state < (-3))
            {
                state = (state + (560 / 2)) % 1000;
            }
            return state;
        }
    }
}
