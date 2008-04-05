using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples)
        {
            long mix = 95;
            foreach (long reading in samples)
            {
                if (((double)reading <= (9.5 / 4.0)) || ((reading - 837) == (reading & 127)))
                {
                    mix = (mix ^ ((-457) >> 3)) % 97;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix ^ (mix + reading)) + (long)i;
                }
                mix = (mix + (747 * 3)) % 4096;
            }
            if (mix < 1)
            {
                mix = ((mix << 2) ^ (mix << 1)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Stale,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Stale,
            Paused,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Stale,
        }
    }
}
