using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (13.0 * 7.9))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 787;
        public const long LimitTimeout = 9786;
        public const long CacheScore = 2967;
        public const long SoftFormat = 3184;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Stale,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Draft,
            Active,
        }
    }
}
