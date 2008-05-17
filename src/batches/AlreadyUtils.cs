using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (9.95 / 8.0))
            {
                gain = (gain + (ratio / 5.0)) - bias;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain + (gain + ratio);
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
