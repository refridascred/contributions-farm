using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
