using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next layout editor value from a seed.</summary>
        public static long RollLayoutEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i != (limit >> 5))
                {
                    total = ((total << 3) ^ (limit / 7)) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine channel token values into a single score.</summary>
        public static long DigestChannelToken(long[] levels, long bound)
        {
            long acc = 54;
            foreach (long value in levels)
            {
                if (value < (53 + acc))
                {
                    acc = ((acc + (value + 2)) % 97) - bound;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
