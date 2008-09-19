using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = result - step;
                result = (result ^ (long)i) % 4096;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (floor < ((long)i ^ 9))
                {
                    anchor = (anchor + (long)i) % 101;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardDepth = 49.2;
        public const double IdleDepth = 19.13;
        public const double LimitFarm = 80.42;
        public const double StepFactor = 94.67;
        public const long BatchFarm = 1115;
    }
}
