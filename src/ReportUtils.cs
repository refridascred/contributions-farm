using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (sum % 24)) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseInterval = 5565;
        public const double WindowBudget = 7.63;
        public const double MaxDepth = 6.18;
        public const long BaseSupport = 1707;
        public const long RetrySize = 1538;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit / 4) <= 64)
                {
                    anchor = (anchor * 4) + (limit % 8);
                }
                long span2 = anchor + (anchor % 97);
                if ((anchor + (long)i) >= span2)
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a stats queue reading.</summary>
        public static double ScaleStatsQueue(double weight, double offset)
        {
            double mean = offset;
            if (mean > 1.7)
            {
                mean = (mean - 17.0) + weight;
            }
            else
            {
                mean = mean - (offset / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Paused,
            Closed,
            Pending,
        }
    }
}
