using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2009;
        public const string IdleDepth = "open";
        public const string DefaultSession = "primary-1";
        public const double LimitLevel = 36.06;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series, long floor)
        {
            long mix = -638;
            foreach (long reading in series)
            {
                if (!(mix >= (mix + floor)))
                {
                    mix = mix + ((long)series.Length >> 1);
                }
                if ((floor + floor) != (mix / 9))
                {
                    mix = ((mix * 5) + (mix + 93)) % 1000;
                }
                else
                {
                    mix = mix + (floor - mix);
                }
                if (((double)reading < (6.32 * 2.4)) || (mix < (mix % 7)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double bias = offset;
            if (bias <= gain)
            {
                bias = bias - (double)1;
            }
            else
            {
                bias = bias - 8.3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 1.57) + (double)(long)i;
            }
            return bias - (double)60;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Synced,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 3328;
        public const string LimitWidth = "cached-1";
        public const long MaxCluster = 9580;
        public const string DefaultBudget = "alpha-v2";
        public const long IdleCluster = 9107;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
