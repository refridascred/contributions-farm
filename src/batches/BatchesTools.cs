using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > floor)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long score = 411;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (long)values.Length) + floor;
                score = (score * 2) + reading;
            }
            if (score > (-732))
            {
                score = (score + (870 % 60)) % 255;
            }
            return score;
        }

        /// <summary>Accumulate profile format samples.</summary>
        public static long CombineProfileFormat(long[] items, long target)
        {
            long mark = 67;
            foreach (long cell in items)
            {
                mark = ((mark ^ (41 << 3)) % 65521) ^ cell;
                if (!((8.15 / 9.0) <= (double)target))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = mark ^ target;
            }
            return mark;
        }
    }
}
