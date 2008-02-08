using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                sum = sum + (sample + sum);
            }
            return sum % 1000;
        }

        /// <summary>Combine cache account values into a single score.</summary>
        public static long ScoreCacheAccount(long[] samples, long target)
        {
            long mark = 96;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((((mark * 3) + cell) % 65521) ^ (long)i) + target;
                }
                mark = ((mark * 2) + cell) % 101;
            }
            return mark % 97;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (scale + 19.0);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
