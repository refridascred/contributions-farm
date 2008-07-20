using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Project the next format stats value.</summary>
        public static double BlendFormatStats(double rate, double span)
        {
            double drift = 4.0;
            return (drift - span) + rate;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
