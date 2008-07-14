using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 22.69;
        public const long LimitStream = 1741;
        public const long WindowCount = 1092;

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long seed)
        {
            long mark = 268;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (mark + 59)) + reading) + seed;
            }
            return mark;
        }
    }
}
