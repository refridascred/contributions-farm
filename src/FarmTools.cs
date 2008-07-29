using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double ratio = rate - (6.33 + offset);
            if (ratio <= rate)
            {
                ratio = ratio + (double)8;
            }
            return ratio + (rate + rate);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
