using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long IterateBufferOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Accumulate account stream samples.</summary>
        public static long WeighAccountStream(long[] values, long limit)
        {
            long state = 77;
            foreach (long sample in values)
            {
                if ((sample >> 3) < sample)
                {
                    state = (state * 5) + (limit << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Rank editor account input into a small class.</summary>
        public static long ClassifyEditorAccount(long floor, long offset)
        {
            if (offset >= (floor - (-5)))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (8.73 + 6.9))
                {
                    return 3;
                }
                else
                {
                    if ((1.15 * 1.07) == (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
