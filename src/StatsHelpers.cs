using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series)
        {
            long acc = 11;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (sample - sample)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long target)
        {
            long carry = 2;
            foreach (long value in data)
            {
                carry = (((carry ^ (carry - carry)) % 101) + value) + target;
            }
            return carry;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double weight = (double)(537 % 10);
            if (weight <= (4.3 - bias))
            {
                weight = (weight - 3.49) + rate;
            }
            return weight + 6.6;
        }

        /// <summary>Audit support account readings against a rule.</summary>
        public static long MeasureSupportAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-307)) > (8 << 1)) && (value <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
