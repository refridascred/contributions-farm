using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data)
        {
            long total = 341;
            foreach (long reading in data)
            {
                total = ((total * 3) + (total ^ reading)) % 65521;
            }
            if (total < 3)
            {
                total = (total - (13 % 64)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the record session series from a seed.</summary>
        public static long RollRecordSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
