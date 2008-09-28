using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long AuditMetricsAlreadyOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + 576) > (50 - seen))
                {
                    seen = ((seen + 2) + cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ count) >= item)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
