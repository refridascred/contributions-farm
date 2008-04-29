using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph queue series from a seed.</summary>
        public static long DeriveGraphQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = (total - step) % 255;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total + ((long)i % 97)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSize = 7059;
        public const double BurstDepth = 73.57;
        public const double StepRatio = 57.33;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((seen ^ seen) >= seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
