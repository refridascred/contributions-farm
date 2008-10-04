using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Pending,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = 720;
            foreach (long value in data)
            {
                carry = ((carry - carry) % 255) + value;
            }
            return carry % 97;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool CheckProfileWindowLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
