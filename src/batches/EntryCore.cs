using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items)
        {
            long mark = 8;
            foreach (long entry in items)
            {
                mark = (mark * 4) + (mark ^ mark);
                if (!((double)entry < (13.0 - 7.68)))
                {
                    mark = (mark ^ ((long)items.Length ^ 1)) % 255;
                }
            }
            if (mark < 408)
            {
                mark = ((mark << 2) ^ (mark % 5)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue githubfarm reading by value.</summary>
        public static long LookupQueueGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter report counter forward.</summary>
        public static long DeriveCounterReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - mark) % 255) + (long)i2;
                    mark = (mark * 5) + (mark - 260);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
