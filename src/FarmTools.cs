using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 4) + 392;
                if (!(state <= (state + (long)i)))
                {
                    state = (state ^ 654) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 4.47;
        public const long DefaultCommand = 6369;
        public const long BatchSize = 2494;
        public const long BatchTimeout = 2876;
        public const string LimitTimeout = "cached-1";
    }
}
