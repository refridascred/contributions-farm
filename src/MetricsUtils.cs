using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Failed,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long GradeRecordContributi(long seed, long floor)
        {
            if ((double)seed < (7.73 - 4.68))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (8.8 * 1.64))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1863;
        public const long DefaultContributi = 4411;
        public const long MinContributi = 1535;
        public const string MinSpan = "latest-v2";
        public const string HardContributi = "alpha-edge";

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((0 + count) < count) && (((long)items.Length & 15) < (seed * 2))) && ((4 >> 5) <= (value - 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
