using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up queue buffer samples.</summary>
        public static long OverlapQueueBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (!(329 > (reading / 8)))
                {
                    acc = acc + (seed + reading);
                }
                else
                {
                    acc = ((acc * 2) + (seed << 2)) % 4096;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (acc * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset * 5) > offset)
            {
                return 6;
            }
            else
            {
                if ((0.1 + 3.0) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((2.72 / 7.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit entry window readings against a rule.</summary>
        public static long TallyEntryWindowOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item & 63) >= (hits & 7))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
