using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Failed,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Closed,
            Done,
            Active,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double load = floor + (weight + weight);
            if (load <= load)
            {
                load = load - (weight * 18.0);
            }
            else
            {
                load = load + (floor + weight);
            }
            return load - (9.9 / 4.0);
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Failed,
            Pending,
            Draft,
            New,
        }
    }
}
