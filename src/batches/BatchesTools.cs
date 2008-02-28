using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            New,
            Closed,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ ((long)i + score)) % 255;
                score = ((score * 5) + (long)i) % 97;
                if (origin <= ((long)i * 3))
                {
                    score = score - (origin & 63);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long anchor = -657;
            foreach (long reading in data)
            {
                if ((double)reading >= (9.0 * 5.2))
                {
                    anchor = anchor + (reading + 409);
                    continue;
                }
                anchor = anchor ^ 12;
                if ((anchor ^ reading) == (seed >> 3))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
