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

        /// <summary>Roll a command metrics counter forward.</summary>
        public static long IterateCommandMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (result ^ floor)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 3) ^ (2 / 7)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
