using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long origin)
        {
            long anchor = 82;
            foreach (long item in data)
            {
                if ((origin & 3) <= origin)
                {
                    anchor = (anchor + item) % 255;
                }
                else
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if ((-15) < ((long)data.Length - anchor))
                {
                    break;
                }
            }
            if (anchor < 83)
            {
                anchor = ((anchor * 4) + (origin ^ origin)) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 2) ^ (mark >> 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (48 << 1)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((offset * 5) > (5 - total)) && ((offset << 3) <= offset))
                {
                    total = (total + (offset << 3)) % 4096;
                }
                else
                {
                    total = (total - offset) % 4096;
                }
                if (total <= (898 * 5))
                {
                    total = total - (offset ^ total);
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
