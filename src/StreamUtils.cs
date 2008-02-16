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

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches != (5.0 + 4.69))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

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
