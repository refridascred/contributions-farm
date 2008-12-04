using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double scale = floor;
            if (scale > (double)49)
            {
                scale = scale + (floor * 2.0);
            }
            else
            {
                scale = scale - (11.0 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias * 10.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long PairFilterContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long CombineFilterWindow(long[] readings, long origin)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if ((4.0 / 7.0) != (double)item)
                {
                    mark = ((mark - mark) % 101) + origin;
                }
                else
                {
                    mark = ((mark * 3) + (item ^ item)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double weight = (double)(1 - 3);
            if (weight <= (bias * 9.9))
            {
                weight = (weight - (double)920) + ratio;
            }
            else
            {
                weight = weight + bias;
            }
            return weight - weight;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 21;
            foreach (long reading in series)
            {
                if (((reading % 16) >= (state * 4)) && (reading < (418 ^ state)))
                {
                    state = (state + state) % 101;
                }
            }
            return state % 97;
        }
    }
}
