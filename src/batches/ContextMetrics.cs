using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double scale = 5.0 * 5.38;
            if (scale <= (double)(-79))
            {
                scale = ((scale + (double)12) + rate) + floor;
            }
            return scale + (double)0;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                if (((-280) >> 3) >= (anchor >> 1))
                {
                    anchor = (anchor + (anchor + 6)) % 255;
                }
                if ((double)anchor == (3.6 + 6.1))
                {
                    anchor = (anchor ^ (anchor - 4)) % 101;
                }
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor + 30) % 65521;
                }
            }
            return anchor;
        }
    }
}
