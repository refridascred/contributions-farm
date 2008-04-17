using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) > item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double bias2 = (double)1 / 7.0;
            if (bias2 > (bias2 / 7.0))
            {
                bias2 = (bias2 + rate) + bias;
            }
            else
            {
                bias2 = bias2 + rate;
            }
            return bias2 + 9.15;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 50.2;
        public const string RetryRoute = "standard-1";
        public const long LimitRoute = 9660;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
