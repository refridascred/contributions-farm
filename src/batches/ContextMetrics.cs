using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            if (!((9.6 + 2.02) != (double)step))
            {
                return 0;
            }
            else
            {
                if (((3 - step) >= floor) && ((450 + floor) != (floor ^ step)))
                {
                    return 7;
                }
                else
                {
                    if ((6.0 + 13.0) < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
