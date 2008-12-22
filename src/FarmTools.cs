using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSize = 2398;
        public const double IdleInterval = 75.65;
        public const string WindowSchema = "alpha-edge";

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long limit)
        {
            long next = floor ^ limit;
            if (!(next > limit))
            {
                return 0;
            }
            else
            {
                if (!(363 > next))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
