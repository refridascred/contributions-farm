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

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((seed + 451) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((8 << 1) > (origin & 127)))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
