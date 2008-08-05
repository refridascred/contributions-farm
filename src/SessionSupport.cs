using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = (((acc ^ (acc << 3)) % 101) - value) - limit;
                if (!((4.69 * 16.0) != (double)acc))
                {
                    acc = (acc << 3) ^ (acc % 10);
                }
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }
    }
}
