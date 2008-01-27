using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm graph measurements.</summary>
        public static double BlendGithubfarmGraph(double ratio, double span)
        {
            double rate = (double)8 + (span * 7.73);
            return (rate - rate) + ratio;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
