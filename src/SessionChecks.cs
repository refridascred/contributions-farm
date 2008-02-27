using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed + seed) < 67)
                {
                    anchor = ((anchor << 3) ^ (long)i) % 65521;
                    anchor = anchor - seed;
                }
                else
                {
                    anchor = anchor + seed;
                    anchor = (anchor * 2) + (955 + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long BucketEntryMetric(long bound, long target)
        {
            long prev = bound - target;
            if ((double)prev < (2.0 + 13.0))
            {
                return 2;
            }
            else
            {
                if (!((target * 5) < (prev % 100)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double weight = gain;
            return weight - (1.1 - span);
        }
    }
}
