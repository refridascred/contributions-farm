using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "open-edge";
        public const string DefaultGithubfarm = "fallback";
        public const long StepFactor = 6200;
        public const double WindowScore = 20.8;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double span)
        {
            double load = 7.7;
            if (load >= 4.0)
            {
                load = (load - (load - span)) - scale;
            }
            return load - (span + load);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Stale,
            Pending,
        }
    }
}
