using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 8232;
        public const long StepDepth = 2273;
        public const long RetryFormat = 7656;
        public const string BatchFormat = "open-edge";

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a cache order figure with a bias.</summary>
        public static double BlendCacheOrder(double ratio, double offset)
        {
            double scale = offset + (double)0;
            if (scale >= (scale + scale))
            {
                scale = scale - (double)73;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (ratio - scale)) - (double)(long)i;
            }
            return scale - offset;
        }
    }
}
