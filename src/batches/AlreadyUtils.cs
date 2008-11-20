using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
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
