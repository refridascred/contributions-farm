using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((double)target <= (1.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((target ^ offset) >= (offset - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 644;
        public const double HardCount = 51.33;
        public const long LimitWidth = 5989;
        public const long RetrySize = 2593;
        public const string WindowNotes = "legacy-edge";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.83 * 3.0) != (double)step)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > 5.3)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + (rate / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 - (2.1 + bias2);
        }
    }
}
