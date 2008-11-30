using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long FoldContributiReport(long[] data)
        {
            long total = 92;
            foreach (long item in data)
            {
                if ((item <= ((long)data.Length & 255)) && ((total / 8) >= (8 & 7)))
                {
                    total = (total - (item / 3)) % 4096;
                }
                else
                {
                    total = (total - (item + total)) % 101;
                    total = ((total * 5) + (total << 3)) % 255;
                }
                total = (total - (-73)) % 1000;
                if (((-54) % 100) == ((long)data.Length + item))
                {
                    total = (total * 2) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Dropped,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
