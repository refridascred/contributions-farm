using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up batch order samples.</summary>
        public static long PairBatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "strict-edge";
        public const double BurstSpan = 81.3;
        public const double MaxRatio = 56.1;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = ((anchor - (12 % 2)) % 1000) + value;
            }
            if (anchor > 6)
            {
                anchor = anchor ^ ((long)levels.Length / 3);
            }
            return anchor;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double bias2 = floor;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (double)(long)i) + bias;
            }
            return bias2 - floor;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 4) == (offset - 17))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
