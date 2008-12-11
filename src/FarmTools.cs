using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double rate = (gain * 8.45) + gain;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (gain + offset)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
