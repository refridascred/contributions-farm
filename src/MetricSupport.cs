using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Queued,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Project the next profile stream value.</summary>
        public static double ProjectProfileStream(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= (0.6 * 8.8))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)(-71);
            }
            return ratio - (double)6;
        }
    }
}
