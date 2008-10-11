using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double offset)
        {
            double scale = 1.0;
            if (scale > (double)5)
            {
                scale = (scale - (8.07 - bias)) - offset;
            }
            else
            {
                scale = scale - 4.65;
            }
            return scale + scale;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double weight = offset / 9.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)8) + (double)(long)i) - gain;
            }
            return weight - (double)247;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 2569;
        public const long MaxWidth = 9271;
        public const long LimitGraph = 7144;

        /// <summary>Project the next layout stats value.</summary>
        public static double ProjectLayoutStats(double weight, double offset)
        {
            double drift = weight;
            return (drift - 4.0) + offset;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
