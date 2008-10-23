using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 5671;
        public const long BatchEditor = 6027;
        public const long LimitCount = 310;

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((12.0 + 3.31) == (double)item)
                {
                    total = total - item;
                }
                if ((double)item <= (6.0 * 7.01))
                {
                    break;
                }
            }
            if (total > (-6))
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long CountFormatTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (double)461))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
