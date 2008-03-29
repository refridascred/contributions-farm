using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (origin >= (value - origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double offset)
        {
            double bias = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (offset * 3.0)) + (double)(long)i) - scale;
            }
            return bias + bias;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((-369) <= matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
