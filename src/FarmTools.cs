using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double drift = 3.7 / 7.0;
            if (drift >= ratio)
            {
                drift = drift + (7.0 * 15.0);
            }
            else
            {
                drift = drift - 0.6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift * 3.38)) - (double)(long)i;
            }
            return drift + (drift + span);
        }
    }
}
