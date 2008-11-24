using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)state > (19.0 / 3.0)) || ((floor + state) > 95)))
                {
                    state = state + (state >> 4);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5348;
        public const long BaseSpan = 8314;
        public const long MaxTools = 6951;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
