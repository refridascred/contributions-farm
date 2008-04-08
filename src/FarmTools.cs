using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long bound)
        {
            if ((bound >> 5) < target)
            {
                return 8;
            }
            else
            {
                if (!((double)target >= 8.3))
                {
                    return 5;
                }
                else
                {
                    if ((target < bound) || ((target >> 4) < (target % 12)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((0.2 * 3.6) > (double)bound) || (((-89) + target) <= (-18)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultTimeout = 50.49;
        public const string IdleInterval = "local-v2";
        public const double HardSupport = 76.0;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Paused,
            Dropped,
        }
    }
}
