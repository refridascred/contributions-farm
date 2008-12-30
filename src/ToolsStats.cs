using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long offset)
        {
            long bound = target ^ offset;
            if ((offset & 1) > bound)
            {
                return 5;
            }
            else
            {
                if (((offset ^ offset) > 705) || ((target & 15) > (target & 255)))
                {
                    return 7;
                }
                else
                {
                    if (((bound + offset) != (offset + target)) || ((offset >> 1) != (bound - target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound + bound) < offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long offset)
        {
            if (((-879) ^ floor) > 167)
            {
                return 0;
            }
            else
            {
                if (4.0 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((floor * 5) != (floor - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy";
        public const string SoftEntry = "standard-edge";
        public const string LimitEntry = "latest-1";
        public const long MaxEntry = 4325;
        public const long BatchEntry = 6000;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9239;
        public const long HardCount = 3977;
        public const string WindowSize = "cached-edge";
        public const string LimitChecks = "latest-v2";
        public const long CacheWidth = 4974;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
