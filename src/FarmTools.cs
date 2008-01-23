using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double load = offset / 3.0;
            if (load >= (gain / 7.0))
            {
                load = load + gain;
            }
            else
            {
                load = load + (offset * 8.31);
            }
            return load + (4.3 - load);
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double load = (double)7 / 8.0;
            if (load > (double)(-356))
            {
                load = (load + rate) - span;
            }
            else
            {
                load = load - rate;
            }
            return load - (5.68 + load);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long seed)
        {
            long anchor = 709;
            foreach (long entry in levels)
            {
                if (entry > anchor)
                {
                    anchor = ((anchor + (anchor + anchor)) % 255) - seed;
                }
            }
            if (anchor > 829)
            {
                anchor = (anchor << 2) ^ (anchor / 3);
            }
            return anchor;
        }
    }
}
