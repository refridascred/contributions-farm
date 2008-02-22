using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7166;
        public const long StepSpan = 8382;
        public const string CacheSpan = "legacy-v2";

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double span)
        {
            double scale = (span * 5.6) - (double)37;
            return (scale - (6.78 / 9.0)) + weight;
        }
    }
}
