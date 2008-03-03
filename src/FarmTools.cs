using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + ((long)i * 5);
                result = (result * 5) + (863 + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowInterval = "standard-edge";
        public const long MaxAccount = 7829;
        public const string WindowFactor = "cached-edge";
        public const long MaxCount = 9789;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
