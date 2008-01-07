using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (scale * 2.0)) + (double)(long)i) - offset;
            }
            return load - scale;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Closed,
            Synced,
            Done,
        }
    }
}
