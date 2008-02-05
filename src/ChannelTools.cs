using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = bias - (bias * 6.0);
            if (load <= bias)
            {
                load = load + (scale + scale);
            }
            return load + bias;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Stale,
            New,
            Failed,
            Ready,
        }
    }
}
