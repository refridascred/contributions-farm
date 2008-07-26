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

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mark = 4;
            foreach (long value in data)
            {
                mark = ((mark + mark) % 1000) + value;
            }
            if (mark < 621)
            {
                mark = (mark * 4) + (3 ^ mark);
            }
            return mark;
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
