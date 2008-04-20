using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a support account sample.</summary>
        public static long LookupSupportAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheRatio = 9091;
        public const double MinLevel = 58.11;
        public const long BurstProfile = 803;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long result = -48;
            foreach (long entry in items)
            {
                result = (result + (entry ^ 23)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (9 <= (tally << 3))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
