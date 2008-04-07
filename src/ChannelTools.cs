using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (double)271)
            {
                drift = (drift + (11.0 / 6.0)) + bias;
            }
            return drift - (double)151;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long floor)
        {
            long sum = 52;
            foreach (long datum in items)
            {
                sum = sum ^ (floor + floor);
                if ((5 & 255) < (floor + floor))
                {
                    sum = sum - (sum - datum);
                }
                else
                {
                    sum = ((sum * 3) + (sum - floor)) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = sum - (floor + floor);
            }
            return sum;
        }
    }
}
