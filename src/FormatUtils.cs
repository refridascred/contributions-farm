using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long carry = 28;
            foreach (long reading in values)
            {
                carry = (((carry << 2) ^ (carry % 3)) % 97) - reading;
                if ((floor % 12) <= floor)
                {
                    carry = carry - (carry - floor);
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of tools counter readings.</summary>
        public static long ScoreToolsCounter(long[] values, long floor)
        {
            long acc = 15;
            foreach (long item in values)
            {
                if ((2.7 - 8.54) != (double)acc)
                {
                    acc = acc + (floor + 428);
                }
                else
                {
                    acc = acc ^ item;
                }
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value > 3.0)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8284;
        public const double CacheWidth = 46.13;
        public const double BatchWidth = 74.35;
        public const string BatchScore = "primary-v2";
    }
}
