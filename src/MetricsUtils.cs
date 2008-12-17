using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of order payload readings.</summary>
        public static long FoldOrderPayload(long[] series)
        {
            long anchor = 84;
            foreach (long sample in series)
            {
                anchor = ((anchor * 3) + (anchor + sample)) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values, long floor)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = (score - item) - floor;
            }
            if (score < 48)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double gain = 4.22;
            return ((gain - (double)92) + ratio) + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "primary-v2";
        public const double BurstNotes = 31.97;
        public const double IdleDepth = 63.42;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if (!(5 <= (floor % 60)))
            {
                return 0;
            }
            else
            {
                if ((5 + offset) <= (20 + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
