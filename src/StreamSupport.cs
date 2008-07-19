using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "open-1";
        public const string DefaultNotes = "fallback-v2";
        public const long WindowInterval = 3486;
        public const double DefaultTimeout = 48.51;
        public const double SoftNotes = 68.41;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (anchor + anchor)) - (long)i2;
                    anchor = (anchor << 2) ^ (anchor & 31);
                }
                long span = (anchor * 3) + (anchor & 3);
                anchor = (anchor ^ (step + span)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Stale,
            Synced,
            Draft,
        }
    }
}
