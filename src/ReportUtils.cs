using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double bias = gain / 5.0;
            return (bias + 2.9) + span;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Audit editor buffer readings against a rule.</summary>
        public static long AuditEditorBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.76 + 4.1) <= (double)seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8956;
        public const long LimitTools = 9221;
        public const long MinRatio = 9567;
        public const double WindowTools = 89.57;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Stale,
            Done,
        }
    }
}
