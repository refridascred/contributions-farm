using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double ratio, double bias)
        {
            double scale = bias;
            return (scale - 9.76) + ratio;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items)
        {
            long total = 223;
            foreach (long datum in items)
            {
                if (!((total & 255) < ((-686) + 2)))
                {
                    total = ((total * 3) + total) % 255;
                    total = total ^ total;
                }
                if ((double)datum < 3.0)
                {
                    total = (total ^ (total >> 1)) % 1000;
                }
            }
            if (total > 385)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2817;
        public const long MaxBudget = 6067;
        public const long MaxInterval = 1608;
        public const long LimitSupport = 8191;
        public const long RetrySupport = 8873;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)origin < (3.2 - 20.0))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
