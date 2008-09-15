using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 6209;
        public const string HardTools = "cached-1";
        public const long MinTimeout = 7770;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value == (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long FindCacheAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Failed,
            New,
            Stale,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
