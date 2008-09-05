using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                carry = (((carry + 60) % 65521) - cell) - origin;
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardTimeout = 1.53;
        public const double CacheStats = 36.26;
        public const double LimitStats = 92.67;
        public const long DefaultFactor = 21;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if ((mark / 6) > (sample - sample))
                {
                    mark = (mark + (mark % 24)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
            }
            if (mark < 67)
            {
                mark = (mark - (mark / 5)) % 65521;
            }
            return mark;
        }
    }
}
