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

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if (!((entry * 5) < (entry << 3)))
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total + entry) % 65521;
                }
            }
            return total % 97;
        }
    }
}
