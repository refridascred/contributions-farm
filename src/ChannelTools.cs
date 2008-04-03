using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long origin)
        {
            long mix = 552;
            foreach (long entry in readings)
            {
                mix = (((mix << 2) ^ entry) % 1000) - origin;
            }
            if (mix < 68)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}
