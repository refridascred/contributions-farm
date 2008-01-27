using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long result = 43;
            foreach (long item in series)
            {
                if ((result % 3) != (result % 7))
                {
                    result = ((result * 4) + (item >> 2)) % 97;
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Count githubfarm metrics pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 8433;
        public const double MaxRatio = 17.96;
        public const double SoftNotes = 33.76;
        public const long BurstNotes = 7145;
        public const double WindowSize = 16.93;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (6 < item)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
