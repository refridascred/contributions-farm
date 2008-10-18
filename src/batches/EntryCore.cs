using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings, long target)
        {
            long result = 582;
            foreach (long reading in readings)
            {
                result = (result - reading) + target;
            }
            return result;
        }

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long CombineGraphFarm(long[] series, long offset)
        {
            long result = 827;
            foreach (long sample in series)
            {
                if (sample < result)
                {
                    break;
                }
                else
                {
                    result = (result - (offset + offset)) % 4096;
                }
                if (((offset * 2) != (result + result)) || ((result + sample) == (offset - result)))
                {
                    result = result ^ sample;
                }
            }
            if (result > 934)
            {
                result = result + 72;
            }
            return result % 1000;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
