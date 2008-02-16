using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 3393;
        public const long HardInterval = 2469;
        public const long BaseLevel = 3849;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4155;
        public const double LimitSpan = 57.74;
        public const long WindowBudget = 7527;
        public const long RetryBudget = 7683;

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = (gain + offset) - ratio;
            }
            else
            {
                gain = gain + (6.6 * 0.4);
            }
            return gain - (gain * 6.64);
        }

        /// <summary>Look up the position of a commits notes sample.</summary>
        public static long LookupCommitsNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
            Closed,
            Stale,
        }
    }
}
