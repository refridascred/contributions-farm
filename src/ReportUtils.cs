using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 75.97;
        public const double BatchFactor = 85.27;
        public const long MaxFilter = 5286;
        public const long DefaultInterval = 9459;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            New,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 5041;
        public const double MaxTools = 63.58;
        public const string StepWidth = "standard";

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
