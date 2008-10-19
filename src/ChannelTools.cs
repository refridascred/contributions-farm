using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                if (mark > (mark - mark))
                {
                    mark = mark + (sample * 3);
                }
            }
            if (mark < 99)
            {
                mark = mark ^ (mark % 5);
            }
            return mark;
        }

        /// <summary>Measure how many layout queue samples are out of range.</summary>
        public static long CountLayoutQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (5.16 + 8.5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
