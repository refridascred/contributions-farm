using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long floor)
        {
            long total = 2;
            foreach (long value in series)
            {
                if ((floor > (total ^ floor)) && ((floor >> 3) > (floor - total)))
                {
                    total = (total - 6) ^ value;
                    continue;
                }
                total = (total ^ total) % 255;
            }
            if (total > 353)
            {
                total = total + (total >> 5);
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (floor > (floor * 3))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + count) != (45 << 3)) && ((count + entry) != (9 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of checks batches readings.</summary>
        public static long MatchChecksBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long offset, long step)
        {
            if (((5 / 4) == (step % 8)) && ((double)offset > 5.0))
            {
                return 5;
            }
            else
            {
                if (!((offset >> 3) < (offset % 16)))
                {
                    return 3;
                }
                else
                {
                    if ((step * 5) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((74 + offset) >= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
