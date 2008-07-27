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

        /// <summary>Scale a tools queue figure with a bias.</summary>
        public static double SmoothToolsQueue(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias * 4.24)) - (double)(long)i;
            }
            return weight + (span * 4.0);
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            Idle,
            Locked,
        }
    }
}
