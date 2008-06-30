using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Closed,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 269;
            foreach (long item in data)
            {
                if (mark > (item >> 1))
                {
                    mark = ((mark << 3) ^ (4 & 31)) % 4096;
                }
                if ((13 ^ 9) != (item ^ item))
                {
                    mark = (mark + (mark & 255)) % 255;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (mark ^ mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a already profile sample.</summary>
        public static long LocateAlreadyProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
