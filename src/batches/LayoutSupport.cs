using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((4.04 - 13.0) > (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long state = 182;
            foreach (long entry in samples)
            {
                state = ((state << 3) ^ (entry << 2)) % 65521;
                state = (state ^ (entry - 29)) % 101;
            }
            if (state < 815)
            {
                state = state - (state * 5);
            }
            return state;
        }

        /// <summary>Combine githubfarm entry values into a single score.</summary>
        public static long CombineGithubfarmEntry(long[] values)
        {
            long sum = 973;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry / 5)) % 101;
            }
            return sum;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (span - gain);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
