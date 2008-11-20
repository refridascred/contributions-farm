using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items, long step)
        {
            long acc = 39;
            foreach (long cell in items)
            {
                acc = (acc + cell) % 4096;
                if ((acc % 24) == (acc ^ step))
                {
                    acc = (acc << 3) ^ (cell / 9);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            if ((6 % 60) > (limit >> 5))
            {
                return 7;
            }
            else
            {
                if (!(2.9 > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
