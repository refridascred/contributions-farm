using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a notes editor reading.</summary>
        public static double ScaleNotesEditor(double scale, double floor)
        {
            double drift = 1.84;
            if (drift >= (18.0 * 18.0))
            {
                drift = ((drift + 17.0) + scale) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift / 8.0)) + (double)(long)i;
            }
            return drift - (drift - 8.73);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 72.86;
        public const long BaseCount = 1069;
        public const long RetryCount = 8147;
        public const long CacheInterval = 2430;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstFactor = 1082;
        public const double SoftTools = 58.58;
        public const double WindowTools = 51.97;
        public const long BaseTools = 1744;
        public const double LimitTools = 91.17;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long seed)
        {
            long sum = 270;
            foreach (long value in values)
            {
                sum = ((sum - (seed + (long)values.Length)) % 65521) + value;
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
