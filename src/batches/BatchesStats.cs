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

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double ratio = (floor * 3.0) / 9.0;
            if (ratio >= floor)
            {
                ratio = (ratio - (double)4) - rate;
            }
            else
            {
                ratio = ratio - (ratio + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 5.7) + (double)(long)i;
            }
            return ratio + 0.4;
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
