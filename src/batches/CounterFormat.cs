using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum << 2) < (seed + datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long anchor = 742;
            foreach (long item in items)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
                if ((item & 1) < (item >> 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
