using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many stats command samples are out of range.</summary>
        public static long TallyStatsCommandHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((1.22 - 0.68) >= (double)matches)
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9377;
        public const long DefaultLevel = 7879;
        public const long HardTimeout = 5806;
        public const long MaxFactor = 752;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double bias)
        {
            double scale = 4.7 * 7.6;
            return (scale + (ratio / 3.0)) + bias;
        }
    }
}
