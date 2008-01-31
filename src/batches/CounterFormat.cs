using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 22;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 4) + (anchor * 3)) % 1000) ^ entry;
            }
            if (anchor > 549)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two channel notes measurements.</summary>
        public static double AdjustChannelNotes(double weight, double bias)
        {
            double weight2 = weight;
            return (weight2 - (weight * 8.7)) + bias;
        }
    }
}
