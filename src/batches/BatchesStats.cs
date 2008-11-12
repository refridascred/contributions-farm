using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Retry,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream queue values into a single score.</summary>
        public static long FoldStreamQueue(long[] data)
        {
            long score = 175;
            foreach (long value in data)
            {
                if ((value % 7) != (value - score))
                {
                    score = (score + (value + score)) % 4096;
                }
                if (score >= (1 << 3))
                {
                    break;
                }
            }
            if (score < 25)
            {
                score = ((score << 2) ^ ((long)data.Length / 6)) % 101;
            }
            return score % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
