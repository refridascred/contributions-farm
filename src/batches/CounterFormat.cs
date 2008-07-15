using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result << 2) ^ (floor << 1)) % 255) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels, long step)
        {
            long anchor = 634;
            foreach (long reading in levels)
            {
                if ((reading * 2) < (long)levels.Length)
                {
                    anchor = ((anchor << 3) ^ (step & 31)) % 97;
                }
                else
                {
                    anchor = anchor + (anchor + reading);
                }
            }
            return anchor % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepInterval = "stable-edge";
        public const long CacheSpan = 3412;
        public const string MinDepth = "latest-1";
        public const long SoftLevel = 2898;
    }
}
