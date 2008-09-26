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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
