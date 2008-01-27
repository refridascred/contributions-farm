using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell >> 5) >= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 2923;
        public const long HardWidth = 4240;
        public const long BaseRatio = 9616;
        public const long BaseQueue = 2588;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen <= (value << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((8.77 / 9.0) == (double)limit) || (anchor < (limit + 739)))
                {
                    anchor = ((anchor * 5) + limit) % 97;
                    anchor = (anchor * 3) + ((long)i * 2);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
