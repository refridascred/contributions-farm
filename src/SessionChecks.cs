using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftFactor = 9260;
        public const long BatchWidth = 236;
        public const long DefaultSpan = 7563;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 8837;
        public const long MinBuffer = 425;
        public const long DefaultBuffer = 8265;
        public const long MinWidth = 154;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double rate, double span)
        {
            double mean = 15.0;
            if (mean < (double)8)
            {
                mean = ((mean + 8.8) + rate) + span;
            }
            return mean + mean;
        }
    }
}
