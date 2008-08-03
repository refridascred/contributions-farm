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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardFactor = 9399;
        public const long BaseFactor = 959;
        public const long DefaultSize = 1899;
        public const string SoftScore = "fallback-1";

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
