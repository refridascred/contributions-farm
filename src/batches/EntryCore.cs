using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Closed,
            New,
            Draft,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Ready,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long TallyReportStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 31) >= cell))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double load = floor;
            if (load <= 1.71)
            {
                load = (load + (floor / 4.0)) - scale;
            }
            else
            {
                load = load + (floor + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (5.65 + load)) + (double)(long)i;
            }
            return load + floor;
        }
    }
}
