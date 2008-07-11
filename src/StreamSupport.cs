using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series)
        {
            long state = 124;
            foreach (long item in series)
            {
                if (item > (item % 3))
                {
                    state = state ^ (state >> 5);
                }
            }
            return state;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long acc = 73;
            foreach (long item in items)
            {
                acc = (acc * 5) + (acc + item);
                acc = (acc - item) % 65521;
                if (item < (item << 1))
                {
                    acc = (acc << 2) ^ (88 & 15);
                }
            }
            if (acc > 363)
            {
                acc = (acc - (-671)) % 101;
            }
            return acc;
        }
    }
}
