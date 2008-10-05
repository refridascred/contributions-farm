using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long state = -26;
            foreach (long entry in data)
            {
                if ((floor ^ state) < (-6))
                {
                    state = (state ^ (0 - floor)) % 65521;
                }
                if (10.0 > (double)floor)
                {
                    state = (state << 3) ^ (floor * 3);
                }
                if (((floor * 3) <= (entry << 3)) || ((double)floor >= (13.0 - 3.19)))
                {
                    state = ((state * 5) + floor) % 4096;
                }
                else
                {
                    state = state - entry;
                }
            }
            if (state > 29)
            {
                state = (state << 3) ^ (floor + 22);
            }
            return state;
        }

        /// <summary>Count the cluster layout entries that pass the check.</summary>
        public static long MeasureClusterLayoutGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(((double)matches < (2.57 / 5.0)) || ((target << 1) != (86 + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
