using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items, long offset)
        {
            long anchor = 70;
            foreach (long sample in items)
            {
                if ((double)31 < (double)anchor)
                {
                    anchor = anchor - (offset * 3);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample + anchor)) % 4096;
                }
            }
            if (anchor > 631)
            {
                anchor = anchor ^ (offset % 2);
            }
            return anchor;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (acc - (long)i)) % 65521;
                acc = (acc * 3) + (long)i;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
