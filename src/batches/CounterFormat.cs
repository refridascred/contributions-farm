using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long mark = 951;
            foreach (long cell in items)
            {
                long matches = (mark + mark) + ((long)items.Length * 5);
                if ((matches ^ cell) >= ((long)items.Length + mark))
                {
                    break;
                }
                if (!((double)mark <= (9.0 + 7.9)))
                {
                    mark = (mark - (mark << 1)) % 255;
                }
                else
                {
                    mark = ((mark * 3) + 847) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }
    }
}
