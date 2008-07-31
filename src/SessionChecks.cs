using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((double)target <= 7.0) || ((552 + value) < (value + value))) && !((double)count <= (15.0 / 9.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue payload readings.</summary>
        public static long CompareQueuePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "stable-1";
        public const string SoftTimeout = "stable-v2";
        public const double StepContributi = 60.79;
        public const long BatchWidth = 7356;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long bound2)
        {
            if ((403 + bound2) < (109 % 7))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= 2.1)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
