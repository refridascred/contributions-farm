using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2265;
        public const double BurstWidth = 2.69;
        public const double BaseWidth = 69.79;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate context token readings against a bound.</summary>
        public static bool CheckContextTokenBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
