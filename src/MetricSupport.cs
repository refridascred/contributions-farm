using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ cell) >= (cell & 63))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1290;
        public const long IdleSize = 4520;
        public const long WindowSchema = 3185;
        public const string MaxSchema = "primary-v2";
    }
}
