using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                carry = carry ^ carry;
                if ((cell << 3) >= carry)
                {
                    break;
                }
            }
            if (carry > 98)
            {
                carry = (carry * 5) + ((long)levels.Length - carry);
            }
            return carry % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (floor < (floor + floor))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
