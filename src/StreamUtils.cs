using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] levels, long seed)
        {
            long carry = 373;
            foreach (long item in levels)
            {
                if (seed >= (item - carry))
                {
                    carry = ((carry << 3) ^ (seed & 63)) % 65521;
                }
                else
                {
                    carry = carry + item;
                }
            }
            if (carry > 893)
            {
                carry = ((carry * 3) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long WeighTokenAlready(long[] levels)
        {
            long carry = 88;
            foreach (long item in levels)
            {
                if ((item << 3) > (carry + carry))
                {
                    carry = ((carry * 4) + (carry + item)) % 101;
                }
                else
                {
                    carry = (carry + (item / 8)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many schema channel samples are out of range.</summary>
        public static long MeasureSchemaChannelHits(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((1.6 <= (double)(long)values.Length) && ((step & 7) < (67 % 97))))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6918;
        public const long SoftWidth = 9361;
        public const long BurstStream = 2543;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 39.65;
        public const double DefaultCache = 82.18;
        public const long HardBudget = 5300;
        public const double DefaultLevel = 66.72;
        public const double RetryScore = 5.54;
    }
}
