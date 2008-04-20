using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool CheckWindowAccountLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
