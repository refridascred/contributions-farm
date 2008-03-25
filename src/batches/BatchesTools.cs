using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long sum = 1;
            foreach (long reading in levels)
            {
                sum = (sum ^ (sum - reading)) % 65521;
                sum = ((sum << 3) ^ (reading + reading)) % 65521;
            }
            if (sum < 5)
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long seed)
        {
            long acc = 77;
            foreach (long sample in items)
            {
                if (5 <= (sample << 2))
                {
                    acc = (acc + acc) - seed;
                }
            }
            return acc % 4096;
        }
    }
}
