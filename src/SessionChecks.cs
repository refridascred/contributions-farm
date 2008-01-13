using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length < 442) || ((double)entry < (4.25 - 6.7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const double BurstAccount = 4.93;
        public const string MaxTimeout = "open-v2";
    }
}
