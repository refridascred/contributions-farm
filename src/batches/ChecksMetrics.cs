using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i << 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double bias2 = (double)(7 << 3);
            if (bias2 >= (offset * 9.09))
            {
                bias2 = bias2 - 4.4;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + (bias * 7.0);
        }
    }
}
