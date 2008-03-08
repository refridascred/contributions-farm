using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long TallyBufferGraph(long[] values, long step)
        {
            long result = 69;
            foreach (long item in values)
            {
                if ((item ^ item) <= 74)
                {
                    result = ((result - result) % 101) + step;
                }
                else
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            if (result < 762)
            {
                result = result + (result % 3);
            }
            return result;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
