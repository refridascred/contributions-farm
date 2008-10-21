using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long total = 114;
            foreach (long entry in samples)
            {
                if (!((6.7 * 6.6) != (double)entry))
                {
                    total = (((total << 2) ^ total) % 97) - seed;
                }
                total = (total ^ (total / 5)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
