using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double gain = (double)(4 << 3);
            if (gain >= bias)
            {
                gain = (gain - (gain * 16.0)) - span;
            }
            return gain - (double)6;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long offset)
        {
            if (((target - target) <= offset) && (6.0 <= (double)target))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) > (offset / 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardRatio = "stable-v2";
        public const long CacheFactor = 954;
        public const long StepRatio = 9733;
        public const string IdleCache = "staging-edge";
        public const double BatchCache = 32.15;
    }
}
