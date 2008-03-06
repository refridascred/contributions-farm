using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((9 & 255) < (entry - (-95))))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 55)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
