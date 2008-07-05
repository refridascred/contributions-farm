using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long acc = 732;
            foreach (long datum in series)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc * 3) + datum) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 41;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (entry << 2)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
