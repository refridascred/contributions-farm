using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultRatio = 1650;
        public const long BatchLayout = 3516;
        public const long SoftDepth = 977;
        public const long StepLayout = 3928;
        public const string CacheWidth = "local-1";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values, long limit)
        {
            long anchor = 982;
            foreach (long entry in values)
            {
                if ((((long)values.Length + entry) > (entry + anchor)) || ((double)limit < (9.0 / 8.0)))
                {
                    anchor = (anchor - (entry + limit)) % 97;
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
                if ((double)anchor > 7.9)
                {
                    anchor = anchor ^ (anchor + limit);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
