using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!!((double)tally <= (10.0 * 14.0)))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up channel payload samples.</summary>
        public static long PairChannelPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] values)
        {
            long anchor = 49;
            foreach (long value in values)
            {
                if (((anchor >> 3) <= anchor) || ((163 + 8) < anchor))
                {
                    break;
                }
                anchor = (anchor + (anchor + value)) % 65521;
                if ((value / 7) > anchor)
                {
                    anchor = (anchor + (value / 3)) % 255;
                }
            }
            if (anchor < 339)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 97;
        }
    }
}
