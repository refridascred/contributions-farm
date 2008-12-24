using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of stream buffer readings.</summary>
        public static long PairStreamBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long offset)
        {
            if (((double)target > (double)28) && ((double)target <= (2.6 - 9.85)))
            {
                return 2;
            }
            else
            {
                if ((target & 127) < (offset - target))
                {
                    return 4;
                }
                else
                {
                    if ((target + offset) < (offset - 359))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(target > offset))
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
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((9.3 <= (double)item) || ((double)item == (9.0 + 1.14)))
                {
                    acc = ((acc * 2) + (item & 63)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = (acc - 43) % 97;
            }
            return acc % 97;
        }

        /// <summary>Locate a batches session reading by value.</summary>
        public static long SeekBatchesSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
