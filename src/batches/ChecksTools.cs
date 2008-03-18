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

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if ((double)target2 != (9.8 * 3.0))
            {
                return 8;
            }
            else
            {
                if (target <= (target2 * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
