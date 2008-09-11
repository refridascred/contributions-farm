using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 5724;
        public const string BurstTools = "strict-edge";
        public const long CacheTools = 9271;
        public const long RetryTools = 1697;
        public const double WindowWidth = 72.33;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)208 == (double)matches) && ((double)cell <= (3.86 - 19.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
