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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)slot == (7.7 * 3.9))
            {
                return 3;
            }
            else
            {
                if ((7.14 / 4.0) <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (1.2 * 7.6)) || ((floor - bound) < slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.32 + 5.0) <= (double)slot)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
