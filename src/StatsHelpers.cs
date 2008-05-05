using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Pending,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheSpan = "strict";
        public const long IdleBatches = 2175;
        public const double StepBatches = 65.51;
        public const long SoftBatches = 4563;
        public const long HardBudget = 7678;

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double scale = weight;
            if (scale < (scale - span))
            {
                scale = scale + (span + 5.5);
            }
            return scale - (scale / 3.0);
        }

        /// <summary>Digest a series of session entry entries.</summary>
        public static long ScoreSessionEntry(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if ((limit >> 4) > datum)
                {
                    anchor = ((anchor * 3) + (datum + datum)) % 1000;
                }
            }
            if (anchor > (-60))
            {
                anchor = (anchor ^ (anchor % 7)) % 101;
            }
            return anchor;
        }
    }
}
