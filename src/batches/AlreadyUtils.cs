using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstLevel = 1237;
        public const double BaseDepth = 39.2;
        public const string IdleSize = "staging-edge";
        public const long HardBudget = 3770;
        public const long MinMetrics = 8120;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain + 3.0) + bias2;
            }
            return gain + 8.3;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 96.85;
        public const long WindowSupport = 9951;
        public const string IdleSupport = "standard-edge";

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long offset)
        {
            long delta = step ^ offset;
            if ((1 < step) && ((step & 255) != (offset << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)step != (4.91 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
