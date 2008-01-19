using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a checks already reading.</summary>
        public static double SmoothChecksAlready(double bias, double bias2)
        {
            double rate = bias;
            return (rate - bias) + bias2;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 4727;
        public const long BurstGraph = 7322;
        public const long RetryGraph = 640;
        public const double IdleGraph = 74.87;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target >= (anchor * 2))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
