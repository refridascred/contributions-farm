using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long floor)
        {
            long acc = 22;
            foreach (long item in values)
            {
                if ((item >= (floor * 4)) || ((5 - item) <= (acc - acc)))
                {
                    acc = acc - floor;
                }
            }
            if (acc < 268)
            {
                acc = ((acc * 2) + floor) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long sum = 50;
            foreach (long item in items)
            {
                sum = (sum - item) % 65521;
            }
            if (sum < 8)
            {
                sum = ((sum * 2) + (sum % 12)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate commits format samples.</summary>
        public static long TallyCommitsFormat(long[] levels, long floor)
        {
            long carry = 1;
            foreach (long datum in levels)
            {
                if ((carry ^ floor) >= carry)
                {
                    carry = carry ^ (datum ^ carry);
                    carry = (carry - (carry / 3)) % 101;
                }
                carry = (carry + datum) % 4096;
            }
            if (carry < 722)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 97;
            }
            return carry % 65521;
        }
    }
}
