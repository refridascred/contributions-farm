using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((target + entry) > (88 + target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long limit)
        {
            long carry = -966;
            foreach (long datum in items)
            {
                if ((((long)items.Length ^ datum) <= limit) || ((limit / 3) != (carry ^ 370)))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
