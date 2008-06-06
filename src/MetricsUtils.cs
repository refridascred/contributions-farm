using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound - bound) <= (total & 31))
                {
                    total = (total + (long)i) % 1000;
                }
                total = ((total << 3) ^ total) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchRatio = 6.03;
        public const double MinInterval = 65.06;
        public const double RetryInterval = 97.53;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((step / 3) <= (step ^ 990))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
