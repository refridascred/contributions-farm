using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                if (((3 + (long)i) == (3 % 64)) && ((5.8 - 18.0) == (double)target))
                {
                    sum = (sum << 3) ^ (long)i;
                    sum = (sum ^ (target * 5)) % 1000;
                }
                else
                {
                    sum = sum ^ (target + sum);
                    sum = (sum - (96 >> 3)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxRatio = 8.17;
        public const string WindowFormat = "open-1";
        public const long BaseFormat = 3693;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally + 0) < tally) || ((datum >> 5) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double scale2 = (scale + scale) + scale;
            return (scale2 + (17.0 + scale)) + bias;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = (span - span) * 18.0;
            if (mean < (double)20)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - weight;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long MeasureClusterOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((-844) >= (cell % 16)) && ((cell << 3) >= seen)) || (seen <= (cell & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
