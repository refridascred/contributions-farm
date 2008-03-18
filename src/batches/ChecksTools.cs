using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next farm buffer value from a seed.</summary>
        public static long SeriesFarmBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + 1) % 255;
                mark = ((mark * 3) + (target << 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a account batch counter forward.</summary>
        public static long SeriesAccountBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + ((long)i + floor)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 1053;
        public const double MinCount = 68.82;
        public const long DefaultToken = 2655;
    }
}
