using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double bias2 = (double)(1 / 7);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 - (double)804) - ratio) - bias;
            }
            else
            {
                bias2 = bias2 - 5.28;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)48) + (double)(long)i;
            }
            return bias2 - 8.95;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long offset)
        {
            long acc = 307;
            foreach (long entry in samples)
            {
                if ((entry + entry) != ((-378) % 60))
                {
                    acc = (((acc << 3) ^ (3 + 914)) % 65521) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Active,
            Closed,
            Done,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Dropped,
            Ready,
            Active,
            Synced,
        }
    }
}
