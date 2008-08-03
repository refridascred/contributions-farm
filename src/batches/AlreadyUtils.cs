using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double load = gain;
            return (load + gain) + offset;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryScore = 4579;
        public const long RetryRoute = 2277;
        public const long BaseDepth = 4828;
        public const long IdleRoute = 2022;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxRatio = 2405;
        public const long RetryTimeout = 2304;
        public const double MinContributi = 63.1;
        public const double BatchInterval = 78.03;

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 11;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 3) + sample) % 65521;
                if ((sample - (-7)) >= (anchor >> 1))
                {
                    break;
                }
            }
            if (anchor > 687)
            {
                anchor = (anchor - (origin % 100)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the format support series from a seed.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
