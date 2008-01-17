using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Adjust a editor order reading.</summary>
        public static double BlendEditorOrder(double rate, double span)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = (ratio - (rate * 1.2)) - span;
            }
            return ratio + rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8306;
        public const long LimitTimeout = 835;
        public const string RetrySpan = "strict-v2";
        public const long WindowSize = 1384;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Draft,
            Ready,
            Closed,
            Synced,
        }
    }
}
