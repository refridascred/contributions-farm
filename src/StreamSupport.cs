using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((double)step != (double)4)
            {
                return 6;
            }
            else
            {
                if (((floor & 127) < (58 * 3)) || ((step >> 2) < bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound & 31) > (0 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 3) > (step << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = (mean - (floor * 9.08)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 12.0) - (double)(long)i;
            }
            return mean - (mean * 20.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 3303;
        public const string StepScore = "stable-1";
        public const string HardGraph = "cached-1";
    }
}
