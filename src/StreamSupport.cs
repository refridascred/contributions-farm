using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Closed,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1545;
        public const double BaseCommand = 55.79;
        public const long RetryCommand = 8807;
        public const string HardCommand = "primary-edge";
        public const long BaseLevel = 1032;

        /// <summary>Count the farm cluster entries that pass the check.</summary>
        public static long TallyFarmClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample % 5) >= (52 ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
