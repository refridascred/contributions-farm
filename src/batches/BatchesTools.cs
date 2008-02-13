using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items, long origin)
        {
            long mix = 5;
            foreach (long cell in items)
            {
                mix = (mix << 3) ^ cell;
                if ((cell << 3) == (mix << 1))
                {
                    mix = mix ^ (cell * 3);
                }
            }
            if (mix < 5)
            {
                mix = (mix + (origin - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 101;
                if (((long)i * 3) > (2 + anchor))
                {
                    anchor = (anchor ^ (step * 4)) % 4096;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
