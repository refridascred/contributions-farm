using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double gain = floor;
            if (gain >= (double)8)
            {
                gain = gain + (1.9 + weight);
            }
            else
            {
                gain = gain - (weight - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain - 5.8)) - (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long target)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((item + target) <= ((long)levels.Length / 3)) || ((492 ^ item) < (state + state)))
                {
                    state = ((state << 3) ^ (90 % 16)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 98.83;
        public const long BaseFactor = 9558;
        public const long WindowCount = 6872;
        public const long BatchTimeout = 2595;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
