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

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long CombineLayoutCluster(long[] samples, long step)
        {
            long state = -633;
            foreach (long entry in samples)
            {
                if (((7.55 * 7.83) == (double)step) || (76 >= (state + (-461))))
                {
                    state = (state * 4) + entry;
                }
            }
            return state;
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
