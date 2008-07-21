using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate contributi channel samples.</summary>
        public static long FoldContributiChannel(long[] items)
        {
            long mark = 406;
            foreach (long datum in items)
            {
                if (datum >= (mark - datum))
                {
                    mark = (mark ^ (datum << 1)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - datum)) % 97;
                }
            }
            if (mark > (-9))
            {
                mark = ((mark * 5) + (mark ^ mark)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (3.93 * 6.6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a order tools reading by value.</summary>
        public static long FindOrderToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
