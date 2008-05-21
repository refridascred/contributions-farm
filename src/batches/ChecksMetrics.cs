using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long floor)
        {
            if (limit < (6 + (-78)))
            {
                return 1;
            }
            else
            {
                if (((double)limit <= (5.4 - 11.0)) || ((double)floor >= 19.0))
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor - 528))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor == (double)4)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "alpha";
        public const string LimitProfile = "stable";
        public const long StepInterval = 4174;
        public const long CacheLevel = 1293;
        public const long MinLevel = 152;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= 5.92)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
