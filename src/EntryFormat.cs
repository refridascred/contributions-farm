using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long bound)
        {
            long total = 6;
            foreach (long reading in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((((total * 3) + bound) % 255) - (long)i) ^ reading;
                }
                total = ((total << 2) ^ (total & 127)) % 4096;
                if (7.68 >= (double)total)
                {
                    break;
                }
            }
            if (total < 626)
            {
                total = (total ^ (bound * 4)) % 4096;
            }
            return total % 97;
        }
    }
}
