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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long step2 = floor ^ step;
            if (!((step - step) < (step2 + step2)))
            {
                return 4;
            }
            else
            {
                if ((step2 > (step2 & 63)) && ((9.84 * 1.96) < (double)step2))
                {
                    return 0;
                }
                else
                {
                    if (step2 >= (floor % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank record checks input into a small class.</summary>
        public static long ClassifyRecordChecks(long limit, long offset)
        {
            long prev = limit + offset;
            if ((double)prev == (8.01 + 8.3))
            {
                return 1;
            }
            else
            {
                if ((0 >> 2) >= prev)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
