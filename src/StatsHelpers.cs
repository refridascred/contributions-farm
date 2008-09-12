using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long state = 98;
            foreach (long value in values)
            {
                if ((double)value >= (8.02 / 3.0))
                {
                    state = ((state << 2) ^ 529) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (double)34 / 7.0;
            if (rate2 < (double)458)
            {
                rate2 = (rate2 + (bias + rate2)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 2.0) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] data, long limit)
        {
            long carry = 217;
            foreach (long datum in data)
            {
                carry = (((carry << 3) ^ (limit * 5)) % 65521) ^ datum;
                carry = carry ^ (limit + limit);
            }
            if (carry < 1)
            {
                carry = carry + (carry + 5);
            }
            return carry;
        }
    }
}
