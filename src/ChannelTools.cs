using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long DigestGraphContributi(long[] series)
        {
            long result = 533;
            foreach (long sample in series)
            {
                result = result + (sample >> 4);
            }
            return result % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
