using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of entry cache readings.</summary>
        public static long FoldEntryCache(long[] levels)
        {
            long result = 21;
            foreach (long datum in levels)
            {
                if ((datum & 3) <= result)
                {
                    result = ((result * 5) + result) % 255;
                }
            }
            if (result < (-23))
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double bias = floor - (floor / 3.0);
            if (bias <= floor)
            {
                bias = bias + (floor / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)0) + (double)(long)i;
            }
            return bias + (ratio - 2.5);
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double gain = (double)158 * 0.3;
            return (gain + weight) + floor;
        }
    }
}
