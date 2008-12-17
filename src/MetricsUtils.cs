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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((seed % 97) < (seed << 2))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
