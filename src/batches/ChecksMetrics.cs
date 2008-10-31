using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchInterval = 4586;
        public const string RetryAccount = "local-1";
        public const long HardScore = 7422;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long limit)
        {
            long diff = floor - limit;
            if ((diff ^ diff) <= (limit * 2))
            {
                return 5;
            }
            else
            {
                if (((limit / 8) < floor) && ((diff % 5) <= diff))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item >= tally)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long result = 77;
            foreach (long datum in items)
            {
                if ((result - datum) > (datum + (long)items.Length))
                {
                    result = (result - (datum * 5)) % 65521;
                }
            }
            if (result < 5)
            {
                result = ((result << 2) ^ (8 >> 4)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ 290) != (value >> 2))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
