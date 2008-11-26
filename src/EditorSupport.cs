using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3414;
        public const long LimitScore = 1908;
        public const long WindowTimeout = 868;
        public const long BurstCluster = 9835;
        public const long MaxBudget = 916;

        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double ProjectBufferProfile(double bias, double bias2)
        {
            double mean = (double)99 / 3.0;
            if (mean >= bias)
            {
                mean = mean - (mean / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - (bias2 * 13.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "alpha-v2";
        public const double MinRecord = 98.91;
        public const double HardRecord = 21.38;
        public const string SoftBudget = "legacy-1";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context cache value against two limits.</summary>
        public static long SortContextCache(long target, long target2)
        {
            long diff = target ^ target2;
            if ((diff % 3) >= (target2 % 24))
            {
                return 8;
            }
            else
            {
                if (((target + diff) > target2) || ((2.6 * 1.9) <= (double)target2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
