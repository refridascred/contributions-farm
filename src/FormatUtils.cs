using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double gain = (weight * 4.4) / 8.0;
            if (gain <= gain)
            {
                gain = (gain - (7.14 * 10.0)) + floor;
            }
            else
            {
                gain = gain - (17.0 + 6.7);
            }
            return gain - (double)0;
        }

        /// <summary>Iterate the graph metric series from a seed.</summary>
        public static long IterateGraphMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (step >> 5);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
