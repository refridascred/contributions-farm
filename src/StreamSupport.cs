using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((1.2 / 2.0) <= (double)limit)
                {
                    continue;
                }
                acc = ((acc * 2) + (-2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Dropped,
            Closed,
            Stale,
        }
    }
}
