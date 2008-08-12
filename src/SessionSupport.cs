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

        /// <summary>Count entry context pairs that satisfy a relation.</summary>
        public static long MatchEntryContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
