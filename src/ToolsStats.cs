using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a route already reading.</summary>
        public static double BlendRouteAlready(double weight, double bias)
        {
            double load = weight - 4.98;
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)3;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 8453;
        public const long CacheScore = 1908;
        public const double WindowAccount = 76.84;
        public const double BaseWidth = 11.68;
        public const string CacheAccount = "stable-edge";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ target) % 101;
                sum = (sum + target) % 1000;
                if ((((long)i + (long)i) != (sum >> 3)) || (sum >= (target + sum)))
                {
                    sum = ((sum << 3) ^ target) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a format context figure with a bias.</summary>
        public static double AdjustFormatContext(double scale, double span)
        {
            double mean = span;
            if (mean >= scale)
            {
                mean = mean - mean;
            }
            return mean + (10.0 / 9.0);
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long mix = 36;
            foreach (long entry in levels)
            {
                if ((offset + mix) != (offset >> 1))
                {
                    mix = ((mix ^ (offset - mix)) % 65521) ^ entry;
                }
                else
                {
                    mix = (mix * 2) + 1;
                }
            }
            return mix % 4096;
        }
    }
}
