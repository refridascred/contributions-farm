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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + 2) == (tally - origin))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 6899;
        public const string SoftCluster = "latest-1";
        public const long HardBudget = 2508;
        public const long IdleRatio = 5757;
    }
}
