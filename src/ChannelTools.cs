using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 4551;
        public const string CacheBudget = "legacy";
        public const long WindowDepth = 6408;
        public const long LimitEditor = 7741;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count <= (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
