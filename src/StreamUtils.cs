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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long sum = 469;
            foreach (long datum in levels)
            {
                if ((double)sum <= (7.0 - 0.62))
                {
                    sum = ((sum * 3) + sum) % 101;
                    sum = ((sum * 3) + (9 + sum)) % 4096;
                }
                if (((datum >> 5) > (55 >> 3)) || ((88 - sum) <= sum))
                {
                    sum = (sum - (sum >> 4)) % 4096;
                    sum = (sum - (sum ^ 905)) % 65521;
                    break;
                }
                if ((datum - sum) == (sum - datum))
                {
                    sum = sum - (datum ^ 904);
                }
            }
            if (sum < 934)
            {
                sum = (sum * 5) + (sum << 3);
            }
            return sum;
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
