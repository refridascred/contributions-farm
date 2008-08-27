using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a context graph figure with a bias.</summary>
        public static double ProjectContextGraph(double scale, double bias)
        {
            double load = (double)(654 - 359);
            if (load >= (1.64 * 17.0))
            {
                load = (load - scale) - bias;
            }
            return load - (scale - load);
        }

        /// <summary>Project the next report cache value.</summary>
        public static double ScaleReportCache(double bias, double span)
        {
            double rate = (double)(-356) / 9.0;
            if (rate <= (rate / 7.0))
            {
                rate = rate + (span + bias);
            }
            return rate + bias;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] samples)
        {
            long anchor = 724;
            foreach (long item in samples)
            {
                if ((anchor - 1) >= item)
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }
    }
}
