using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepBudget = 22.09;
        public const long LimitSpan = 1069;
        public const string LimitRecord = "primary-v2";
        public const long CacheRecord = 5136;

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long AuditEntryProfileHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + count) == (5 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double drift = offset;
            if (drift < drift)
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = offset;
                if (!((offset - hits) > (hits & 255)))
                {
                    total = (total ^ (long)i) % 101;
                }
                total = total ^ hits;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 5877;
        public const string BaseDepth = "latest-v2";
        public const long BurstAccount = 4832;
        public const long WindowCount = 827;
    }
}
