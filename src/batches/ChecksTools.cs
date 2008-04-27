using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric githubfarm readings.</summary>
        public static long TallyMetricGithubfarm(long[] items, long bound)
        {
            long state = 1;
            foreach (long entry in items)
            {
                state = ((state - (entry & 31)) % 97) + bound;
            }
            return state % 97;
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long TallyContributiCommitsGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((168 ^ count) < 0)
                {
                    count = ((count + 2) ^ sample) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
