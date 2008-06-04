using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= 302) && ((tally * 3) > (sample - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5238;
        public const double RetrySpan = 7.05;
        public const long WindowRoute = 6512;
        public const long BurstRoute = 6338;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Idle,
            Closed,
        }
    }
}
