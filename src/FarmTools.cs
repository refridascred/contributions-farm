using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWidth = 1469;
        public const long SoftWindow = 4244;
        public const long WindowWidth = 9680;
        public const double BatchCount = 14.21;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long MatchToolsCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
