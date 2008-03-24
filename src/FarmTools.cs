using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series, long floor)
        {
            long state = 1;
            foreach (long datum in series)
            {
                if ((state ^ datum) <= (165 + floor))
                {
                    state = state ^ floor;
                }
                else
                {
                    state = ((state << 2) ^ (datum << 1)) % 65521;
                }
                if ((((-40) - floor) >= (4 ^ datum)) && ((double)3 < (double)datum))
                {
                    break;
                }
            }
            if (state < 566)
            {
                state = (state << 3) ^ (8 - floor);
            }
            return state;
        }

        /// <summary>Count stats context pairs that satisfy a relation.</summary>
        public static long CompareStatsContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitLevel = 6356;
        public const double WindowTools = 87.61;
        public const long DefaultTools = 6311;
    }
}
