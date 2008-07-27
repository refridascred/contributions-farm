using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Stale,
            Synced,
            Closed,
            Locked,
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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
