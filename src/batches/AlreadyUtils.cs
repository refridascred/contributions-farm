using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9577;
        public const string CacheProfile = "open";
        public const double HardFactor = 24.2;
        public const long WindowFactor = 1353;
        public const long BurstRatio = 6836;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long carry = 46;
            foreach (long value in data)
            {
                if ((value - carry) >= (value + carry))
                {
                    carry = (carry - (value & 255)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (value - value);
                }
            }
            if (carry > 812)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
