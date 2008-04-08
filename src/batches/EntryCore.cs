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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (((score << 3) ^ (score & 7)) % 97) - sample;
            }
            return score;
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

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double span)
        {
            double mean = 0.96;
            if (mean >= span)
            {
                mean = (mean + (mean * 3.0)) + rate;
            }
            return mean + 8.88;
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
