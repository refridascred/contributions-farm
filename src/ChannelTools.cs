using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel window value against two limits.</summary>
        public static long ClassifyChannelWindow(long offset, long floor)
        {
            if ((double)floor > (7.88 + 8.2))
            {
                return 2;
            }
            else
            {
                if (((offset * 2) >= (floor - floor)) && ((offset - offset) > (offset % 100)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
