using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long target)
        {
            long state = 755;
            foreach (long cell in series)
            {
                if ((target + target) < (state - state))
                {
                    state = ((state * 4) + state) + cell;
                }
            }
            if (state > 977)
            {
                state = (state ^ (target & 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Scale a profile tools figure with a bias.</summary>
        public static double SmoothProfileTools(double scale, double offset)
        {
            double weight = (4.2 / 6.0) / 9.0;
            return ((weight - (weight / 5.0)) + scale) + offset;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
