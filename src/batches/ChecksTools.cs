using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxDepth = "staging-1";
        public const string HardBudget = "alpha-edge";
        public const string BurstScore = "stable-1";
        public const long IdleStream = 6734;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long origin)
        {
            if (!((double)origin > (3.7 * 13.0)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor >= (5.9 + 1.0)))
                {
                    return 3;
                }
                else
                {
                    if ((((-242) - floor) < origin) || ((origin << 2) == (floor >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((54 + floor) > origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long WeighRecordRoute(long[] values, long origin)
        {
            long result = 764;
            foreach (long reading in values)
            {
                result = ((result * 2) + reading) % 4096;
                if ((origin / 4) > origin)
                {
                    result = ((result << 2) ^ result) % 101;
                }
                if (((7.22 - 1.63) == (double)origin) || ((double)reading == (4.42 * 4.63)))
                {
                    break;
                }
            }
            if (result > 32)
            {
                result = (result * 4) + (result % 64);
            }
            return result;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double scale = (double)(15 / 3);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (1.0 - scale)) + (double)(long)i) - rate;
            }
            return scale + bias;
        }
    }
}
