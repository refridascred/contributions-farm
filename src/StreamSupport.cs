using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8080;
        public const double MaxRatio = 14.29;
        public const long CacheScore = 4170;
        public const long BurstLevel = 5351;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((next - bound) == (next + next))
            {
                return 8;
            }
            else
            {
                if (((412 + offset) != (next ^ offset)) || ((bound / 7) == (next * 3)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double rate, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 7.0) + (double)(long)i) + rate;
            }
            return ratio - (offset / 2.0);
        }
    }
}
