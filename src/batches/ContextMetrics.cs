using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepScore = "latest-v2";
        public const long IdleFarm = 8713;
        public const long SoftFarm = 1389;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Queued,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitScore = 1256;
        public const long MaxTimeout = 8499;
        public const string StepTimeout = "stable-v2";

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (!((bound >> 1) != (value * 3)))
                {
                    sum = (sum ^ (83 / 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Ready,
            Queued,
        }
    }
}
