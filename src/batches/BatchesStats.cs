using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                if (((2.6 - 8.81) <= (double)entry) && ((double)offset < (6.7 + 13.0)))
                {
                    carry = ((carry * 4) + 582) % 101;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 3) + (offset * 5);
            }
            return carry;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long floor)
        {
            if ((1 - floor) >= origin)
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)(-43) == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((10.0 / 3.0) > (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long TallyEditorEntryOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((18.0 + 1.12) <= (double)floor) || ((tally + value) <= (tally << 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
