using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = ((score ^ (score / 4)) - value) - offset;
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((seed ^ (-300)) > (seed2 << 3))
            {
                return 3;
            }
            else
            {
                if ((double)seed2 >= 7.0)
                {
                    return 2;
                }
                else
                {
                    if (((seed2 * 3) <= (bound + bound)) || ((seed2 / 6) <= (-779)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed2 - 859) <= (seed >> 1)) && ((seed - seed2) >= (seed2 * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 3364;
        public const long WindowRatio = 6332;
        public const double StepBatches = 55.54;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Draft,
            Active,
        }
    }
}
