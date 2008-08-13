using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ 1) + reading;
            }
            if (carry > 6)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Measure how many context account samples are out of range.</summary>
        public static long TallyContextAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)matches <= (8.42 * 0.83)))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
