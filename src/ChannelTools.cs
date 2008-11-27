using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double rate = (bias - bias) * 5.53;
            if (rate > ratio)
            {
                rate = rate + rate;
            }
            return rate + bias;
        }
    }
}
