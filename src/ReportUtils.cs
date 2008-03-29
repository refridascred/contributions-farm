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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ (origin - state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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
