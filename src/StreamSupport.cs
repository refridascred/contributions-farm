using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of graph queue entries.</summary>
        public static long ScoreGraphQueue(long[] series, long bound)
        {
            long sum = 727;
            foreach (long sample in series)
            {
                sum = (sum + (sum + bound)) - sample;
            }
            return sum;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long offset)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ (mark % 100)) % 65521;
                mark = (mark ^ (cell + mark)) % 1000;
            }
            if (mark > 32)
            {
                mark = (mark ^ (mark + offset)) % 97;
            }
            return mark;
        }
    }
}
