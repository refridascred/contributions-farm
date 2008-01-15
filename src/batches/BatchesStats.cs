using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two session record measurements.</summary>
        public static double AdjustSessionRecord(double ratio, double bias)
        {
            double bias2 = (double)(-783) - (bias * 4.9);
            if (bias2 <= 8.65)
            {
                bias2 = (bias2 - (double)2) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - 6.86) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double bias = (double)16 / 7.0;
            if (bias <= (bias * 7.0))
            {
                bias = (bias - (weight + 3.0)) - span;
            }
            return bias + bias;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
