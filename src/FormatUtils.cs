using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TallyContributiChannel(long[] readings, long target)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((30 - 762) > sum)
                {
                    sum = (((sum ^ (sum << 2)) % 1000) - item) + target;
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double weight = 10.0;
            if (weight >= (double)5)
            {
                weight = (weight + (double)38) - scale;
            }
            return weight + (weight - floor);
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long FoldProfileCounter(long[] values, long limit)
        {
            long total = -5;
            foreach (long value in values)
            {
                if (((double)total >= 20.0) || ((long)values.Length != (limit >> 1)))
                {
                    total = (total + (60 - value)) % 1000;
                }
            }
            if (total < 56)
            {
                total = total ^ (total - total);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long floor)
        {
            long total = 3;
            foreach (long cell in items)
            {
                if (453 <= (cell + total))
                {
                    total = (total ^ floor) % 97;
                }
            }
            return total;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long total = 810;
            foreach (long entry in data)
            {
                total = (total << 3) ^ (target - entry);
            }
            if (total < 43)
            {
                total = (total + (total * 4)) % 65521;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "cached-edge";
        public const long BurstCounter = 4452;
        public const long BaseCounter = 9159;
        public const double IdleCounter = 86.12;
        public const string LimitCounter = "primary-1";
    }
}
