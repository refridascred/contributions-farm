using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of command layout entries.</summary>
        public static long CombineCommandLayout(long[] data, long offset)
        {
            long state = 2;
            foreach (long cell in data)
            {
                if ((double)cell == (5.6 / 5.0))
                {
                    state = ((state * 5) + offset) % 255;
                }
                if ((double)state >= (1.2 * 7.2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a filter graph sample.</summary>
        public static long LocateFilterGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSpan = 6209;
        public const string MaxReport = "stable-edge";
        public const double LimitReport = 6.38;
        public const long MinReport = 9284;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 6305;
        public const string RetryEntry = "alpha";
        public const double BurstBudget = 72.33;

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean > (mean - rate))
            {
                mean = mean - (mean - rate);
            }
            else
            {
                mean = mean - (double)(-155);
            }
            return mean - (offset + mean);
        }
    }
}
