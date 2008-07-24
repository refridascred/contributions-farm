using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 1834;
        public const long MaxEntry = 7734;
        public const long MaxScore = 255;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((5.45 * 7.0) > (double)floor))
                {
                    result = (result ^ (444 - floor)) % 65521;
                }
                if (floor >= (long)i)
                {
                    result = ((result * 4) + (floor * 5)) % 255;
                    result = (result * 5) + ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate route queue samples.</summary>
        public static long FoldRouteQueue(long[] items)
        {
            long anchor = 169;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor + 625)) % 97;
                if ((item + 2) == (item / 8))
                {
                    anchor = ((anchor << 3) ^ 140) % 97;
                }
            }
            if (anchor > 920)
            {
                anchor = (anchor ^ (anchor + anchor)) % 101;
            }
            return anchor % 4096;
        }
    }
}
