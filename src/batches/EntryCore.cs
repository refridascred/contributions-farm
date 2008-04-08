using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value & 15) <= (tally & 31))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mark = 79;
            foreach (long cell in levels)
            {
                mark = mark ^ (717 + cell);
                if (mark >= (cell / 5))
                {
                    mark = (mark ^ (cell + 915)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + (mark - cell)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i <= 5.81))
                {
                    score = (score - (target >> 1)) % 255;
                }
                else
                {
                    score = (score << 2) ^ target;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen ^ seen) >= seen) || (((seen & 31) <= (seen * 3)) || ((value & 63) > (value - 672))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
