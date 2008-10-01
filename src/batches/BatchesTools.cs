using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings, long step)
        {
            long mark = 63;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark - (cell & 1)) % 65521) + (long)i) + step;
                }
                mark = mark ^ (cell & 3);
            }
            if (mark < 954)
            {
                mark = (mark + (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] data, long bound)
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
    }
}
