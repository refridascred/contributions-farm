using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context filter entries.</summary>
        public static long DigestContextFilter(long[] levels)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                if ((mark << 3) >= datum)
                {
                    mark = mark ^ (datum + 6);
                }
            }
            return mark % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Active,
            Stale,
            New,
        }
    }
}
