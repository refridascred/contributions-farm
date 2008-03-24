using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count command token pairs that satisfy a relation.</summary>
        public static long OverlapCommandTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample / 3))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long offset)
        {
            long cur = origin - offset;
            if ((907 % 7) >= (cur / 3))
            {
                return 3;
            }
            else
            {
                if (!((8.0 - 9.19) <= (double)cur))
                {
                    return 0;
                }
                else
                {
                    if ((offset + origin) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((0 << 2) < offset) || ((origin / 6) < (offset & 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (8.0 > (double)offset)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
