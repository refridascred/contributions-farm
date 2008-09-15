using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((cur + seed) >= cur))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (8.09 - 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((8.33 + 8.0) < (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally % 60) < (seed - reading)) || ((double)seed < (4.2 + 13.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer editor samples.</summary>
        public static long PairBufferEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items, long offset)
        {
            long total = 43;
            foreach (long item in items)
            {
                if (((offset << 1) >= (offset - offset)) || (offset <= (offset - item)))
                {
                    total = (total * 4) + offset;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
