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

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6913;
        public const string HardCount = "staging";
        public const long IdleSupport = 5888;
        public const long HardSupport = 4559;
        public const long LimitWidth = 6888;

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
