using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double bias = (double)(57 % 10);
            if (bias <= 4.6)
            {
                bias = (bias + (17.0 / 2.0)) + floor;
            }
            else
            {
                bias = bias - (bias + gain);
            }
            return bias - 4.76;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long floor)
        {
            if ((8.0 - 8.0) >= (double)floor)
            {
                return 0;
            }
            else
            {
                if (((target + floor) < (target + target)) && ((target ^ floor) >= (target / 4)))
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ target) > (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((14.0 - 9.01) >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8763;
        public const long WindowRecord = 8256;
        public const string SoftRecord = "open-1";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long target)
        {
            long acc = 72;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - (target / 3)) - (long)i) - entry;
                }
                acc = (acc - (acc & 127)) % 1000;
            }
            if (acc > 4)
            {
                acc = (acc - (target >> 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
