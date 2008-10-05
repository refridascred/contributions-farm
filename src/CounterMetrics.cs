using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double gain = (offset - offset) * 5.95;
            if (gain < gain)
            {
                gain = (gain - gain) - ratio;
            }
            return gain + 1.7;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor * 4) + (8 + anchor);
                anchor = (anchor ^ (long)i) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
