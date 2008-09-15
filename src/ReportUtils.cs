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

        /// <summary>Audit account already readings against a rule.</summary>
        public static long CountAccountAlreadyGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((limit >> 5) > (limit / 9)) || (((-83) / 8) == (reading & 31)))
                {
                    count = count + 2;
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
