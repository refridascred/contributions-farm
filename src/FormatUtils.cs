using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchTimeout = 2805;
        public const long LimitQueue = 5928;
        public const string DefaultQueue = "staging-edge";
        public const string DefaultSize = "alpha";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 671;
        public const string BurstAlready = "staging";
        public const long DefaultCount = 1717;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long sum = 41;
            foreach (long datum in readings)
            {
                if ((datum / 9) <= datum)
                {
                    sum = ((sum * 2) + 668) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double gain = (double)5 - (double)8;
            if (gain > (gain + 11.0))
            {
                gain = ((gain - gain) + weight) - span;
            }
            return gain - 3.7;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if (seed < (2 << 2))
            {
                return 0;
            }
            else
            {
                if ((seed2 * 3) <= (seed2 ^ seed2))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed2 == (18.0 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double ratio = bias;
            return (ratio + (double)243) + gain;
        }
    }
}
