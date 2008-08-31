using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + (carry << 2)) % 255;
                carry = (carry - (target & 31)) % 4096;
                carry = (carry ^ carry) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix - ((long)i2 / 6)) % 1000;
                }
                mix = (mix * 3) + mix;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
