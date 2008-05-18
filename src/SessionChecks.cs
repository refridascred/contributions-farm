using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen >= (double)value)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Pending,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3442;
        public const long BaseLevel = 1627;
        public const long IdleDepth = 7383;
        public const long MaxLevel = 131;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
