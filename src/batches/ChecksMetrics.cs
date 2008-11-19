using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long anchor = 6;
            foreach (long datum in samples)
            {
                anchor = anchor + 136;
                if ((double)datum <= 2.5)
                {
                    anchor = (anchor ^ (anchor >> 2)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + datum) % 97;
                }
            }
            if (anchor < 69)
            {
                anchor = anchor ^ 5;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double span)
        {
            double rate = span;
            return (rate + (rate + 15.0)) + bias;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (((sum << 2) ^ (sum % 7)) % 255) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count > 2.2) && !((count ^ count) > (entry - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
