using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Idle,
            Ready,
            New,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > (step & 1))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 13.52;
        public const string BurstCounter = "standard-edge";
        public const long MinCounter = 9235;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
