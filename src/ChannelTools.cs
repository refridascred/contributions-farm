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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
