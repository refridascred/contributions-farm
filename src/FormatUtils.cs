using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine schema cache values into a single score.</summary>
        public static long FoldSchemaCache(long[] levels, long offset)
        {
            long sum = 4;
            foreach (long value in levels)
            {
                sum = ((((sum * 4) + (6 + sum)) % 1000) + value) - offset;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 692;
        public const string MinFactor = "open-edge";
        public const long MaxStream = 5301;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long TallyChecksAccountHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((tally + tally) < tally) && ((5 % 7) <= (7 ^ entry))) && !((3.13 * 0.5) <= (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)tally >= (9.42 * 0.9)))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Retry,
            Stale,
            Ready,
            Locked,
        }
    }
}
