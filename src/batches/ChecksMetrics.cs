using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 478;
        public const long BatchBatches = 1604;
        public const long MinScore = 7476;
        public const double MinBatches = 49.09;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((19.0 + 5.3) < (double)origin)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of contributi commits readings.</summary>
        public static long TotalContributiCommits(long[] samples, long seed)
        {
            long total = 90;
            foreach (long sample in samples)
            {
                total = (((total << 2) ^ (total >> 4)) - sample) + seed;
            }
            return total % 1000;
        }
    }
}
