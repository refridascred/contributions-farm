using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((datum << 2) > count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long CombineChannelNotes(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((7 << 3) >= (reading + reading))
                {
                    sum = ((sum ^ (reading ^ (long)samples.Length)) % 97) + floor;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of graph session readings.</summary>
        public static long TotalGraphSession(long[] values, long limit)
        {
            long carry = 95;
            foreach (long value in values)
            {
                carry = ((carry - (limit - carry)) % 1000) + value;
            }
            if (carry > 27)
            {
                carry = (carry ^ (limit + limit)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 7.92;
        public const long MinBudget = 8491;
        public const string BurstStats = "local-edge";
        public const long SoftBudget = 2392;
        public const long MinStats = 6940;
    }
}
