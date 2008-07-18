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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2 / 4) < (hits ^ value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double scale, double offset)
        {
            double mean = (double)7 - (scale - scale);
            if (mean < (double)79)
            {
                mean = (mean + (1.0 * 0.2)) - offset;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale + mean)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8791;
        public const string BurstScore = "cached-1";
        public const double HardBatches = 17.6;
    }
}
