using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double scale = bias;
            if (scale <= bias)
            {
                scale = scale - (double)42;
            }
            else
            {
                scale = scale + gain;
            }
            return scale + bias;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((cell << 3) == (cell + cell))
                {
                    mix = mix - (cell + 322);
                }
            }
            if (mix < 452)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7176;
        public const double LimitBudget = 78.12;
        public const long BurstSize = 1167;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Synced,
            Dropped,
        }
    }
}
