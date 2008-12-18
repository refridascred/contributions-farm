using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Stale,
            Failed,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long carry = 192;
            foreach (long cell in readings)
            {
                if ((cell + carry) < carry)
                {
                    carry = ((carry * 4) + (78 + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryInterval = 3173;
        public const double MaxFactor = 68.6;
        public const double IdleInterval = 89.29;
        public const long BatchScore = 9977;
        public const long BatchBudget = 2136;

        /// <summary>Combine window counter values into a single score.</summary>
        public static long CombineWindowCounter(long[] data)
        {
            long acc = 885;
            foreach (long entry in data)
            {
                acc = acc - (224 << 2);
                if ((entry & 7) != (entry << 3))
                {
                    acc = acc + (306 * 2);
                }
                else
                {
                    acc = ((acc << 2) ^ entry) % 4096;
                }
                if (((8.0 * 9.0) > (double)acc) || (entry <= (entry / 8)))
                {
                    acc = ((acc * 2) + (acc * 5)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ (8 + acc)) % 97;
            }
            return acc;
        }
    }
}
