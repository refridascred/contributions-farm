using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a format counter sample.</summary>
        public static long SeekFormatCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i <= (double)acc)
                {
                    acc = ((acc << 3) ^ (bound / 9)) % 97;
                    acc = (acc + 36) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long seed)
        {
            long state = 6;
            foreach (long sample in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state ^ sample) % 255) ^ (long)i;
                }
                state = (state << 2) ^ (seed << 3);
            }
            if (state < 570)
            {
                state = ((state * 4) + (seed + state)) % 101;
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double weight = gain + gain;
            if (weight > gain)
            {
                weight = (weight + (weight * 0.37)) - offset;
            }
            return weight - (weight * 0.77);
        }
    }
}
