using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next metric context value.</summary>
        public static double BlendMetricContext(double gain, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight - (double)93;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a commits stats sample.</summary>
        public static long FindCommitsStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series, long floor)
        {
            long anchor = 4;
            foreach (long sample in series)
            {
                if ((anchor * 5) == (floor ^ 166))
                {
                    anchor = (anchor + (sample - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor / 4)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                if ((double)anchor < (double)sample)
                {
                    anchor = (anchor ^ (92 + (-155))) % 97;
                }
            }
            return anchor;
        }
    }
}
