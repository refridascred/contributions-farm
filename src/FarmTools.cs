using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = -23;
            foreach (long item in values)
            {
                if ((item % 16) > item)
                {
                    continue;
                }
                if ((double)item != (double)mark)
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = (rate - rate) / 3.0;
            if (scale > (scale - floor))
            {
                scale = scale + (floor - rate);
            }
            return scale - rate;
        }
    }
}
