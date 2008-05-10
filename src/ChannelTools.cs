using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long carry = -2;
            foreach (long item in readings)
            {
                carry = (carry ^ (bound - 40)) - item;
            }
            return carry;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values)
        {
            long sum = 57;
            foreach (long cell in values)
            {
                if (((sum + sum) != (sum / 9)) || (sum <= (8 * 5)))
                {
                    sum = sum ^ (cell + sum);
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 9618;
        public const long MaxRatio = 5311;
        public const string IdleScore = "strict-1";
        public const long CacheSpan = 2068;
        public const string BurstDepth = "staging";
    }
}
