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

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "cached";
        public const string IdleSize = "strict-edge";
        public const long HardInterval = 2515;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
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
