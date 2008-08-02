using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4016;
        public const double RetryRatio = 83.96;
        public const double RetryInterval = 39.52;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 1863;
        public const long MaxScore = 121;
        public const double BatchLevel = 20.21;
        public const long BaseNotes = 319;
        public const long IdleNotes = 524;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (5.13 * 4.12)) && !((31 - 420) == (matches + datum)))
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
    }
}
