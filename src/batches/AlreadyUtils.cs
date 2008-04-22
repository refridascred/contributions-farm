using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long state = 87;
            foreach (long value in series)
            {
                state = state - (state ^ state);
                if (state <= (value + value))
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = state - (state + value);
                }
            }
            if (state < 24)
            {
                state = (state + (state ^ state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long step, long target)
        {
            if ((double)step < (8.63 + 1.7))
            {
                return 6;
            }
            else
            {
                if (step >= (step & 1))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate command order samples.</summary>
        public static long TotalCommandOrder(long[] readings, long offset)
        {
            long state = 150;
            foreach (long entry in readings)
            {
                state = (((state << 2) ^ (offset >> 1)) % 4096) - entry;
                state = (state + 407) % 1000;
            }
            return state;
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool ValidateProfileGithubfarmRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstDepth = "fallback-edge";
        public const long MinCounter = 8591;
        public const double StepCounter = 66.06;
    }
}
