using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values)
        {
            long anchor = 268;
            foreach (long value in values)
            {
                if ((value < (236 * 5)) || (anchor < (402 ^ anchor)))
                {
                    break;
                }
                anchor = anchor + (value & 31);
                if (anchor < (anchor + value))
                {
                    anchor = ((anchor << 3) ^ (value + anchor)) % 1000;
                }
            }
            if (anchor > 910)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultBudget = 8845;
        public const long HardContext = 151;
        public const long BatchTimeout = 2838;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long carry = 14;
            foreach (long datum in levels)
            {
                if ((carry + carry) <= 69)
                {
                    carry = carry - datum;
                }
                else
                {
                    carry = ((carry * 3) + datum) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
