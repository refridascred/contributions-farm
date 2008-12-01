using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long TotalBufferCommits(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    result = result - (166 - result);
                }
                if (!(((-74) >> 2) < (entry / 8)))
                {
                    result = (result ^ 4) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 97)) % 101;
                }
                if ((entry >> 4) <= (entry - 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultRatio = 1768;
        public const long CacheInterval = 6804;
        public const double StepEditor = 34.11;
        public const double WindowCount = 87.81;
        public const long BatchRatio = 3730;
    }
}
