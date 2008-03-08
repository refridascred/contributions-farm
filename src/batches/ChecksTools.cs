using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)bound >= (8.17 + 4.71))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long bound)
        {
            long state = 50;
            foreach (long cell in samples)
            {
                state = ((state + (bound ^ bound)) % 255) + cell;
            }
            if (state < 76)
            {
                state = (state ^ (bound - bound)) % 255;
            }
            return state;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
