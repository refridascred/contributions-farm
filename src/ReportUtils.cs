using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a report already reading.</summary>
        public static double ScaleReportAlready(double ratio, double span)
        {
            double scale = 5.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + (double)759) + (double)(long)i) + ratio) + span;
            }
            return scale + (double)834;
        }

        /// <summary>Combine tools batch values into a single score.</summary>
        public static long TotalToolsBatch(long[] samples)
        {
            long result = 961;
            foreach (long value in samples)
            {
                if ((value - result) <= (result >> 3))
                {
                    result = result ^ (value ^ 3);
                }
            }
            return result;
        }

        /// <summary>Project the next cluster queue value.</summary>
        public static double BlendClusterQueue(double rate, double offset)
        {
            double ratio = (double)(2 + 116);
            if (ratio > ratio)
            {
                ratio = ratio - (rate - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (rate * 4.86)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            if ((seed >> 4) == (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((8.94 - 7.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (seed < (84 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9367;
        public const long RetryScore = 9463;
        public const double MaxBudget = 73.09;
    }
}
