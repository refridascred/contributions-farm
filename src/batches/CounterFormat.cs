using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 610;
        public const long StepCount = 942;
        public const string CacheSpan = "fallback-1";
        public const double BaseNotes = 92.57;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((limit ^ limit) >= anchor) && (852 <= (long)i))
                {
                    anchor = ((anchor * 4) + limit) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + (limit + limit)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
