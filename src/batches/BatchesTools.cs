using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long seed)
        {
            long score = 206;
            foreach (long entry in values)
            {
                if ((entry * 4) == (entry % 5))
                {
                    score = ((score << 2) ^ (seed << 2)) % 65521;
                }
                else
                {
                    score = (score + (entry >> 5)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a graph session reading by value.</summary>
        public static long LocateGraphSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
