using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit order commits readings against a rule.</summary>
        public static long AuditOrderCommitsHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < 8.1)
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long origin)
        {
            long acc = 169;
            foreach (long entry in readings)
            {
                if ((entry + acc) > acc)
                {
                    acc = (acc ^ entry) - origin;
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
