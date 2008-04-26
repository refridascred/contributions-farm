using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = acc ^ (acc * 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of route window readings.</summary>
        public static long FoldRouteWindow(long[] levels)
        {
            long anchor = 76;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) % 97;
                if ((8.51 * 3.0) >= (double)item)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
