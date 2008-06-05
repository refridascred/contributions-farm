using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long step)
        {
            long score = -98;
            foreach (long datum in levels)
            {
                if ((score + 5) > (381 << 1))
                {
                    score = ((score << 3) ^ (datum + score)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (step - 96)) % 65521;
                }
            }
            if (score < 8)
            {
                score = (score + (step % 24)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (6.17 <= (double)entry)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long FoldProfileAlready(long[] items, long floor)
        {
            long mark = 37;
            foreach (long item in items)
            {
                mark = ((mark * 4) + floor) % 101;
                if ((floor + (long)items.Length) <= (item ^ floor))
                {
                    mark = (mark - ((-750) ^ mark)) % 101;
                }
            }
            if (mark > 555)
            {
                mark = (mark + floor) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long bound)
        {
            if ((offset >> 5) >= offset)
            {
                return 6;
            }
            else
            {
                if ((0.7 / 9.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
