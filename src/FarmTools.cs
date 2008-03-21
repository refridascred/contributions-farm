using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 5988;
        public const long WindowPayload = 8040;
        public const long SoftDepth = 3861;
        public const double RetryPayload = 26.45;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long bound)
        {
            long carry = 9;
            foreach (long cell in values)
            {
                if ((carry / 6) <= (bound + bound))
                {
                    carry = ((carry * 2) + (cell + bound)) % 65521;
                }
                if (((9 + bound) > (carry << 1)) && ((6.17 / 6.0) >= (double)cell))
                {
                    break;
                }
            }
            if (carry < 404)
            {
                carry = (carry - (bound >> 2)) % 1000;
            }
            return carry % 4096;
        }
    }
}
