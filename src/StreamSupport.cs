using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a graph githubfarm reading.</summary>
        public static double AdjustGraphGithubfarm(double scale, double offset)
        {
            double mean = (double)(259 % 5);
            if (mean >= scale)
            {
                mean = mean + (scale - offset);
            }
            return mean + scale;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
