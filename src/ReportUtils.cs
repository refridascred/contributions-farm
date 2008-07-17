using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((601 >= (sample & 15)) && ((hits / 3) <= (sample ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 296;
            foreach (long cell in values)
            {
                mark = (mark * 2) + cell;
            }
            if (mark < 39)
            {
                mark = (mark ^ (90 % 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "standard-edge";
        public const long HardRoute = 4970;
        public const long MaxInterval = 2549;
        public const long BurstRoute = 4074;

        /// <summary>Derive the next record report value from a seed.</summary>
        public static long RollRecordReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((carry + (long)i) == (carry << 2)) || ((offset & 15) <= (offset << 1)))
                {
                    carry = (carry ^ (offset * 2)) % 1000;
                }
                if ((4 * 3) > (carry + carry))
                {
                    carry = (carry << 2) ^ offset;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
