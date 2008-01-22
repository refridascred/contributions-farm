using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double scale = (double)((-63) % 10);
            if (scale >= (double)4)
            {
                scale = (scale - (span - span)) - ratio;
            }
            return scale - (span - 4.4);
        }

        /// <summary>Blend two buffer entry measurements.</summary>
        public static double SmoothBufferEntry(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < scale2)
            {
                scale2 = (scale2 + (double)617) - scale;
            }
            return scale2 - (double)7;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long score = 95;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (98 - score)) % 97;
                if ((double)value != (2.97 - 15.0))
                {
                    break;
                }
            }
            if (score < 89)
            {
                score = (score << 3) ^ 46;
            }
            return score;
        }
    }
}
