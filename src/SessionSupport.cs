using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultInterval = 28.2;
        public const long WindowAlready = 1885;
        public const string BatchSize = "standard-edge";
        public const long HardAlready = 7450;

        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long AuditToolsEntryGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((origin & 1) != (cell / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
