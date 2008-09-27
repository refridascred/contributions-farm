using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long anchor = 88;
            foreach (long sample in levels)
            {
                long tally = (sample * 3) << 2;
                if (!(anchor <= (tally >> 2)))
                {
                    anchor = (anchor * 3) + (anchor & 31);
                }
                if ((double)anchor == (9.6 + 8.0))
                {
                    anchor = (anchor - sample) % 1000;
                }
                if (((sample >> 5) == (sample - 45)) && ((sample & 1) >= (sample - anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheDepth = 8249;
        public const long RetryRatio = 6360;
        public const long IdleTimeout = 8833;
    }
}
