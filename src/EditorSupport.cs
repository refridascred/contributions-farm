using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Retry,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (step <= 99)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings)
        {
            long state = -9;
            foreach (long reading in readings)
            {
                long matches = ((long)readings.Length * 4) << 1;
                state = (state ^ (matches & 127)) % 4096;
                state = (state << 3) ^ reading;
            }
            if (state > (-2))
            {
                state = ((state * 5) + state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Active,
            Done,
            Idle,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (reading & 63)) % 1000;
                if (((reading - anchor) > anchor) && ((anchor + 59) <= (9 * 5)))
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 65521;
        }
    }
}
