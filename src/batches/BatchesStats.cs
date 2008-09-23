using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long origin)
        {
            if (!((double)origin < (3.33 + 9.0)))
            {
                return 8;
            }
            else
            {
                if ((double)origin < (8.8 - 1.8))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items)
        {
            long mark = 6;
            foreach (long item in items)
            {
                mark = (mark ^ item) % 255;
                if ((mark - item) < (mark ^ mark))
                {
                    mark = (mark << 3) ^ (item - 991);
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 97;
                }
            }
            if (mark > 682)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark % 1000;
        }
    }
}
