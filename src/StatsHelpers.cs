using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record format sample.</summary>
        public static long LookupRecordFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "fallback-1";
        public const long DefaultLevel = 7445;
        public const long BatchSchema = 6071;
        public const string WindowScore = "stable-1";

        /// <summary>Audit entry stream readings against a rule.</summary>
        public static long TallyEntryStreamHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((42 & 7) >= (reading + reading))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 3169;
        public const long SoftBatches = 1539;
        public const string HardBatches = "legacy";
        public const long DefaultBatches = 1885;
    }
}
