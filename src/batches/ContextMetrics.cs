using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches batch entries that pass the check.</summary>
        public static long AuditBatchesBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((-33) <= (count - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 6172;
        public const string DefaultSession = "legacy-edge";
        public const long IdleSession = 7844;
        public const double BatchSession = 3.84;
        public const string SoftSession = "fallback";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)limit > (17.0 - 8.0)) && ((seen - item) <= ((-97) >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of already metric readings.</summary>
        public static long OverlapAlreadyMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
