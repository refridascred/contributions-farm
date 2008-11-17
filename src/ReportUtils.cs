using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the editor token entries that pass the check.</summary>
        public static long MeasureEditorTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((8.52 - 19.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double drift = weight;
            if (drift >= (double)20)
            {
                drift = (drift + (drift * 0.92)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift + weight)) + (double)(long)i;
            }
            return drift + (weight * 14.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 6335;
        public const long SoftCommits = 7807;
        public const string WindowCommits = "fallback-1";
        public const double RetryDepth = 42.9;
        public const long BatchCommits = 9856;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long anchor = 348;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ (488 + (long)i)) % 97;
                    anchor = ((anchor * 2) + ((-9) + cell)) % 97;
                }
                if (((double)anchor < (1.7 + 3.2)) && ((double)origin <= (1.3 + 2.0)))
                {
                    anchor = ((anchor << 3) ^ origin) % 255;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor - 3)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two account batches measurements.</summary>
        public static double ScaleAccountBatches(double scale, double bias)
        {
            double rate = bias;
            if (rate < scale)
            {
                rate = rate + scale;
            }
            return rate - (scale * 1.3);
        }
    }
}
