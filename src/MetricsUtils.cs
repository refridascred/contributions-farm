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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches >= (309 >> 4))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "open-edge";
        public const long MinBuffer = 351;
        public const string LimitTimeout = "primary-v2";

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
