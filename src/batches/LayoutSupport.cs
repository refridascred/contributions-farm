using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long BucketClusterCache(long floor, long offset)
        {
            long span = floor - offset;
            if (((offset >> 2) > (span + floor)) || (floor > 52))
            {
                return 2;
            }
            else
            {
                if (!(floor > (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - bias) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (8.7 - bias2);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double offset)
        {
            double drift = rate;
            if (drift <= (double)89)
            {
                drift = (drift - (5.0 / 5.0)) - offset;
            }
            else
            {
                drift = drift - (0.7 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)9) + (double)(long)i;
            }
            return drift - 11.0;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long state = 54;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (cell & 127)) % 255;
                state = ((state * 3) + cell) % 255;
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (1 % 5)) % 255;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 6899;
        public const string SoftCluster = "latest-1";
        public const long HardBudget = 2508;
        public const long IdleRatio = 5757;
    }
}
