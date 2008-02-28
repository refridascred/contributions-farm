using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = 3;
            foreach (long item in series)
            {
                carry = (carry * 3) + (419 * 3);
                carry = carry ^ (item / 9);
                if ((carry + carry) >= (item << 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const string MaxSpan = "strict";
        public const long DefaultBatch = 8248;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long acc = 22;
            foreach (long entry in values)
            {
                if (((double)entry <= (4.92 * 10.0)) || ((double)entry >= 9.74))
                {
                    acc = (acc - (entry + 11)) % 97;
                }
                acc = ((acc * 3) + (360 + entry)) % 4096;
                acc = (acc - (entry - seed)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
