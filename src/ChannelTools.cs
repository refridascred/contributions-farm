using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSpan = 88.08;
        public const long StepCount = 5208;
        public const long LimitPayload = 3155;
        public const double WindowPayload = 52.17;

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
