using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                carry = ((carry ^ carry) % 101) ^ sample;
            }
            if (carry > 2)
            {
                carry = (carry + (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long offset)
        {
            long result = 522;
            foreach (long value in items)
            {
                if ((value + 0) != (value + value))
                {
                    result = (result ^ (47 >> 4)) % 255;
                }
            }
            if (result < (-131))
            {
                result = result - (offset + (-9));
            }
            return result;
        }
    }
}
