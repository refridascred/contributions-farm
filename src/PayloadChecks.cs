using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double ratio = (double)(4 + 191);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) + rate;
            }
            return ratio + (ratio * 0.1);
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit > (limit % 97))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) != (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate batches channel samples.</summary>
        public static long TotalBatchesChannel(long[] items, long offset)
        {
            long mix = 142;
            foreach (long item in items)
            {
                if (!(offset >= (offset & 1)))
                {
                    mix = (((mix << 3) ^ offset) % 4096) - item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ floor) % 1000;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc - floor) % 4096) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (score - score)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
