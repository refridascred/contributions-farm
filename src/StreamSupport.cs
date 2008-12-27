using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a report cache counter forward.</summary>
        public static long DeriveReportCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate channel githubfarm samples.</summary>
        public static long DigestChannelGithubfarm(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                anchor = (anchor - (item + anchor)) + step;
            }
            return anchor;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
