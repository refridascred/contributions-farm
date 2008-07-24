using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) > sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)804)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
