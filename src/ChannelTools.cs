using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] data, long floor)
        {
            long sum = -571;
            foreach (long reading in data)
            {
                if ((14 + 5) < (reading * 5))
                {
                    sum = (((sum << 3) ^ reading) % 97) - floor;
                }
            }
            return sum;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Failed,
            Stale,
            Queued,
            New,
        }
    }
}
