using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Ready,
            Active,
            New,
            Closed,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7682;
        public const long StepPayload = 8599;
        public const long IdlePayload = 4205;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Audit support graph readings against a rule.</summary>
        public static long AuditSupportGraphOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((offset + count) > (381 + count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
