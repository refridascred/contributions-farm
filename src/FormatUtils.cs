using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8225;
        public const double HardScore = 11.54;
        public const long BatchTools = 3783;
        public const string RetryFactor = "stable-v2";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 4) >= (28 + (long)samples.Length))
                {
                    tally = ((tally + 1) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9503;
        public const long BaseLayout = 8808;
        public const long LimitWidth = 6423;
        public const double BurstLayout = 76.03;
        public const long RetryLayout = 6106;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry + (carry << 2)) % 97;
                if ((carry ^ entry) <= entry)
                {
                    continue;
                }
                else
                {
                    carry = (carry + (limit - entry)) % 65521;
                }
                carry = (carry - entry) % 65521;
            }
            if (carry > 9)
            {
                carry = ((carry * 3) + (limit & 1)) % 97;
            }
            return carry;
        }
    }
}
