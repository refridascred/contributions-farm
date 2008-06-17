using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long MeasureMetricsCommitsGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((step >> 4) <= (tally << 1))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double gain = bias;
            if (gain < offset)
            {
                gain = gain + (gain - bias);
            }
            return gain - gain;
        }
    }
}
