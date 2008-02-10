using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long mark = 944;
            foreach (long sample in items)
            {
                if (((mark + sample) >= (mark + 353)) || ((8 * 2) != (mark - sample)))
                {
                    mark = ((mark * 4) + (sample + 0)) % 65521;
                }
            }
            if (mark < 84)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long carry = 61;
            foreach (long datum in values)
            {
                carry = ((carry << 2) ^ datum) + origin;
            }
            return carry;
        }
    }
}
