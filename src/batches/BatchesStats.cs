using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + tally) > (origin / 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long origin)
        {
            long lane = step ^ origin;
            if ((step ^ lane) <= step)
            {
                return 0;
            }
            else
            {
                if ((step >> 4) < lane)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((89 << 2) < seen)
                {
                    seen = ((seen + 2) + sample) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
