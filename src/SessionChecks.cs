using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Pending,
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 255) < (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
