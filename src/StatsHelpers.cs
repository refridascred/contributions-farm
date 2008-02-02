using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings, long target)
        {
            long mark = 322;
            foreach (long cell in readings)
            {
                mark = mark ^ (target + mark);
                mark = (mark << 2) ^ (cell * 5);
                if (((double)mark < (double)cell) && ((45 >> 5) >= ((-671) ^ cell)))
                {
                    mark = mark ^ (cell << 2);
                }
                else
                {
                    mark = ((mark * 4) + (mark + target)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i >= (42 % 7))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
