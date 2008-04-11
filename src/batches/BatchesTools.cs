using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data)
        {
            long mix = 83;
            foreach (long value in data)
            {
                if ((double)mix <= (18.0 * 18.0))
                {
                    mix = (((mix << 2) ^ (92 & 7)) % 1000) ^ value;
                }
                mix = (mix - (mix % 5)) % 101;
            }
            if (mix < 45)
            {
                mix = ((mix << 3) ^ ((-179) * 4)) % 255;
            }
            return mix;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph channel entries.</summary>
        public static long FoldGraphChannel(long[] samples, long step)
        {
            long acc = 14;
            foreach (long datum in samples)
            {
                acc = ((acc - (datum - datum)) % 4096) - step;
            }
            return acc;
        }
    }
}
