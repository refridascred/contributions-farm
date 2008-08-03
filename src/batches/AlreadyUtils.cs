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

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (weight * 2.9))
            {
                weight = (weight - weight) - gain;
            }
            else
            {
                weight = weight + (0.23 / 6.0);
            }
            return weight + (bias * 2.9);
        }
    }
}
