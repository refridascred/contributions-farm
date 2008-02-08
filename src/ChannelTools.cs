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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (0.6 / 8.0))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
