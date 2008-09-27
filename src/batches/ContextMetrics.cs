using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double gain = bias * 13.0;
            if (gain > (gain / 2.0))
            {
                gain = gain - (double)844;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain + 1.2)) + (double)(long)i;
            }
            return gain - (1.7 - offset);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if ((cell + cell) == (cell << 3))
                {
                    mark = (mark - (36 + mark)) % 255;
                    mark = ((mark << 2) ^ (cell * 2)) % 65521;
                }
                else
                {
                    mark = (mark * 5) + (cell << 2);
                }
                if (((5.85 / 9.0) <= (double)mark) && (6 < cell))
                {
                    mark = (mark + mark) % 101;
                }
                if ((7 - 799) > mark)
                {
                    break;
                }
            }
            if (mark < 126)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every buffer channel entry stays within the limit.</summary>
        public static bool VerifyBufferChannelBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 6143;
        public const string BaseDepth = "primary";
        public const long MinSize = 9120;
        public const double BaseSize = 63.57;
        public const long StepDepth = 6440;
    }
}
