using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 1172;
        public const long MaxPayload = 8495;
        public const string SoftRatio = "latest";

        /// <summary>Hold a booking entry.</summary>
        public sealed class BookingEntry
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + ((long)i + (long)i);
                carry = (carry * 5) + (floor - floor);
                carry = ((carry * 5) + (carry << 2)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
