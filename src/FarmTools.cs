using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double scale2 = (double)126;
            if (scale2 < (double)90)
            {
                scale2 = scale2 + (offset * 0.34);
            }
            return scale2 - (offset + scale);
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
