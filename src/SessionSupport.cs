using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long step)
        {
            long total = 8;
            foreach (long entry in items)
            {
                if ((9.2 - 3.0) > (double)entry)
                {
                    total = ((total - (entry + total)) % 97) + step;
                }
                else
                {
                    total = total - entry;
                }
            }
            if (total < 3)
            {
                total = (total * 5) + (total & 7);
            }
            return total;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 0.8;
            if (mean <= floor)
            {
                mean = (mean + (double)5) + ratio;
            }
            return mean + floor;
        }
    }
}
