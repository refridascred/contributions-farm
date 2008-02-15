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

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long AuditStreamSchemaOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample ^ 7) == (sample / 2))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "fallback-1";
        public const long DefaultLevel = 7445;
        public const long BatchSchema = 6071;
        public const string WindowScore = "stable-1";

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long DigestFarmMetrics(long[] items, long offset)
        {
            long result = 7;
            foreach (long reading in items)
            {
                result = (result ^ (22 ^ result)) + reading;
            }
            if (result > 36)
            {
                result = (result + offset) % 1000;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 3169;
        public const long SoftBatches = 1539;
        public const string HardBatches = "legacy";
        public const long DefaultBatches = 1885;
    }
}
