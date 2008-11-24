using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Locked,
            Retry,
            New,
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
