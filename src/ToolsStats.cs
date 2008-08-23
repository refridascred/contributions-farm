using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "primary";
        public const string MinRatio = "open";
        public const long BurstRecord = 8457;
        public const double StepRecord = 41.56;
        public const string LimitRecord = "strict-v2";

        /// <summary>Find the first buffer counter entry that matches the target.</summary>
        public static long LocateBufferCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 5) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
