using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the graph notes entries that pass the check.</summary>
        public static long TallyGraphNotesOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count != (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
