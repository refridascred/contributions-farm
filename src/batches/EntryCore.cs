using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Ready,
            Closed,
            New,
            Idle,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            if ((seed - seed2) >= seed2)
            {
                return 7;
            }
            else
            {
                if ((seed2 ^ seed) <= (seed2 - seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (4.06 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long step)
        {
            long anchor = 54;
            foreach (long cell in items)
            {
                if (((double)anchor > (7.7 / 3.0)) || ((28 ^ anchor) <= anchor))
                {
                    anchor = anchor - (cell * 3);
                    anchor = (anchor - (cell - cell)) % 97;
                }
                if (((cell - anchor) > step) || ((double)step > (5.06 - 9.0)))
                {
                    anchor = anchor + (cell >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series, long target)
        {
            long total = 79;
            foreach (long sample in series)
            {
                if (((-406) % 3) > target)
                {
                    total = (total - target) + sample;
                }
            }
            if (total > 57)
            {
                total = (total * 2) + ((long)series.Length + total);
            }
            return total % 97;
        }
    }
}
