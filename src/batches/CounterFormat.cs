using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long mix = 317;
            foreach (long sample in series)
            {
                mix = (mix - (25 % 7)) + sample;
            }
            if (mix > 36)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
