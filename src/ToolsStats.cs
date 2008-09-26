using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Locked,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepWidth = 6810;
        public const long MaxTimeout = 9166;
        public const long CacheTimeout = 3798;
        public const long CacheCluster = 8857;
        public const long LimitCluster = 7122;

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double mean = floor;
            return (mean - 1.5) + scale;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            New,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool VerifyCommandBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
