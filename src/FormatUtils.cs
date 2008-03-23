using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double scale2 = (double)(122 & 3);
            if (scale2 < (bias - scale))
            {
                scale2 = scale2 - (double)2;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long step)
        {
            if ((step + seed) < (seed - step))
            {
                return 2;
            }
            else
            {
                if ((step + seed) > (step & 1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long state = 60;
            foreach (long cell in series)
            {
                long offset = (long)series.Length;
                state = (state * 2) + (32 - offset);
                if ((state << 2) >= (cell % 2))
                {
                    state = (state * 4) + state;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double scale = span;
            if (scale > scale)
            {
                scale = (scale - (scale - scale)) + weight;
            }
            else
            {
                scale = scale - span;
            }
            return scale - 6.29;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 3) != (count & 255))
                {
                    count = ((count + 1) ^ datum) + origin;
                }
            }
            return count;
        }
    }
}
