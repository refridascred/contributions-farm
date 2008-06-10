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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Adjust a window filter reading.</summary>
        public static double BlendWindowFilter(double gain, double bias)
        {
            double scale = (double)(195 ^ 11);
            return ((scale + (scale * 7.0)) + gain) + bias;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double ratio = bias;
            return (ratio + (double)243) + gain;
        }
    }
}
