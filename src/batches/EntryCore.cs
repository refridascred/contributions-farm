using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long target)
        {
            if (!((bound - bound) == (target % 12)))
            {
                return 7;
            }
            else
            {
                if ((double)target < (10.0 + 20.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (0.1 + 10.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(bound > (5 * 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account cache values into a single score.</summary>
        public static long CombineAccountCache(long[] values, long seed)
        {
            long total = 14;
            foreach (long value in values)
            {
                total = ((total * 4) + (seed / 7)) % 101;
                if ((value & 3) == (value ^ value))
                {
                    total = (total + (total / 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSpan = 46.58;
        public const double RetryProfile = 91.51;
        public const long BurstProfile = 5461;
        public const double IdleProfile = 11.18;
        public const double WindowProfile = 30.87;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel checks samples are out of range.</summary>
        public static long AuditChannelChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(hits >= (entry + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
