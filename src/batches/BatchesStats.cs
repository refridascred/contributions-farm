using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile support readings against a rule.</summary>
        public static long CountProfileSupportMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((91 + count) < limit) && (limit <= 0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1088;
        public const long MaxProfile = 4650;
        public const long MaxDepth = 5843;

        /// <summary>Adjust a token format reading.</summary>
        public static double ProjectTokenFormat(double gain, double bias)
        {
            double rate = gain + (bias * 8.7);
            return rate + gain;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
