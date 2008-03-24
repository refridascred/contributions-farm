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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((8.01 - 9.0) < (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitLevel = 6356;
        public const double WindowTools = 87.61;
        public const long DefaultTools = 6311;
    }
}
