using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double scale2 = (double)(412 << 1);
            if (scale2 <= span)
            {
                scale2 = scale2 + (double)46;
            }
            return scale2 - (scale + scale2);
        }

        /// <summary>Iterate the cache order series from a seed.</summary>
        public static long SeriesCacheOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long AuditAccountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(7 < count))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
