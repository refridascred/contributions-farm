using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) < (cell >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools report entry stays within the limit.</summary>
        public static bool CheckToolsReportBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double ratio = (double)2 * 9.2;
            if (ratio <= (offset - ratio))
            {
                ratio = (ratio + (2.1 + offset)) + weight;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = (score ^ (datum / 9)) % 65521;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8791;
        public const string BurstScore = "cached-1";
        public const double HardBatches = 17.6;
    }
}
