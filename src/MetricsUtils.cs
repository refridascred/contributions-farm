using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Done,
            Locked,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (offset - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step >= 4.2)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
