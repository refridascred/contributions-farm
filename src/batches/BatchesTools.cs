using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long state = 41;
            foreach (long entry in series)
            {
                if (entry <= (entry & 127))
                {
                    state = ((state * 2) + (state - (-21))) % 4096;
                }
                else
                {
                    state = (state - ((-70) + entry)) % 101;
                }
            }
            if (state > 572)
            {
                state = (state + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] series, long step)
        {
            long anchor = 729;
            foreach (long entry in series)
            {
                if (((step * 4) != (entry >> 2)) && ((double)step <= (3.7 / 9.0)))
                {
                    anchor = ((anchor << 2) ^ (17 % 16)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long acc = 1;
            foreach (long cell in samples)
            {
                acc = acc - (acc - 78);
                if ((double)cell >= (4.2 * 7.41))
                {
                    acc = acc ^ (cell * 2);
                }
            }
            return acc % 97;
        }
    }
}
