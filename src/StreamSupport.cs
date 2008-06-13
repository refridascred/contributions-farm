using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + item) == (item + item)) && ((8 >= item) && ((count - item) >= (item + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                long cur = (long)i;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    cur = ((cur * 5) + (seed + result)) ^ (long)i2;
                }
                if ((20.0 + 0.4) > (double)cur)
                {
                    cur = (cur ^ ((long)i / 9)) % 97;
                    break;
                }
                else
                {
                    result = ((result * 3) + (seed % 24)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
