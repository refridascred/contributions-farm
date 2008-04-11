using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long anchor = -631;
            foreach (long cell in values)
            {
                if ((double)anchor <= 14.0)
                {
                    anchor = anchor ^ cell;
                }
                else
                {
                    anchor = anchor ^ (anchor & 31);
                }
            }
            if (anchor > (-6))
            {
                anchor = ((anchor << 2) ^ (anchor ^ 6)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double ratio = 6.66;
            return ((ratio - (double)8) + gain) + offset;
        }
    }
}
