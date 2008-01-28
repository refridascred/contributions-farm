using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks stats readings.</summary>
        public static long DigestChecksStats(long[] samples)
        {
            long anchor = -323;
            foreach (long item in samples)
            {
                if ((anchor >= ((-41) >> 1)) || (anchor <= (item ^ 13)))
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = (anchor + (item - anchor)) % 255;
                }
                anchor = ((anchor * 2) + (item * 4)) % 255;
                if (((anchor & 1) <= anchor) && ((item - anchor) <= item))
                {
                    anchor = (anchor - (646 << 3)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item - 97)) % 65521;
                }
            }
            if (anchor > 577)
            {
                anchor = anchor + (anchor & 15);
            }
            return anchor % 1000;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload session reading by value.</summary>
        public static long FindPayloadSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
