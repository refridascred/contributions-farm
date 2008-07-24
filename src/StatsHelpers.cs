using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 89.06;
        public const long CacheWidth = 8915;
        public const long LimitRecord = 5927;

        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long SortGraphReport(long offset, long seed)
        {
            if (((offset >> 2) >= (544 + 335)) || ((double)offset > (9.5 * 3.61)))
            {
                return 7;
            }
            else
            {
                if (offset <= (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 4) <= (offset + seed)) || (offset >= (offset >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed < (0.31 * 9.6)) || (offset <= (offset << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile counter pair into a bucket.</summary>
        public static long BucketProfileCounter(long seed, long floor)
        {
            if ((seed <= floor) || ((seed ^ seed) == (floor * 3)))
            {
                return 8;
            }
            else
            {
                if ((seed * 2) <= (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor < (floor / 8)) || (floor < (221 - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.68 / 8.0) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Queued,
            Pending,
            Closed,
            Synced,
        }
    }
}
