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

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long limit)
        {
            long total = 75;
            foreach (long datum in levels)
            {
                if (((total - limit) == (62 - (-9))) && (total >= (5 % 64)))
                {
                    total = (((total * 5) + (total & 31)) % 97) - datum;
                }
                else
                {
                    total = ((total << 3) ^ (46 + limit)) % 255;
                }
            }
            return total;
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
