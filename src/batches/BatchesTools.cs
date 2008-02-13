using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long target)
        {
            long delta = bound ^ target;
            if ((8.09 - 3.0) <= (double)delta)
            {
                return 5;
            }
            else
            {
                if ((8 * 4) < delta)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (2.59 * 4.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
