using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6843;
        public const long WindowBudget = 9107;
        public const long BaseRatio = 7413;
        public const long MaxSize = 9671;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a account metrics pair into a bucket.</summary>
        public static long ClassifyAccountMetrics(long seed, long floor)
        {
            if ((6.2 / 7.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((seed % 24) != (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Compare every pair of graph cluster readings.</summary>
        public static long PairGraphClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
