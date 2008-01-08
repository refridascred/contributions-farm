using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long origin)
        {
            if ((seed % 2) <= origin)
            {
                return 1;
            }
            else
            {
                if ((origin - seed) < (3 % 7))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double scale = (double)9 + bias;
            if (scale < (8.2 - rate))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
