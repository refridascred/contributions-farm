using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultCount = 6416;
        public const long StepSupport = 3178;
        public const long SoftSupport = 8528;
        public const long CacheSupport = 4381;

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long ClassifyNotesAlready(long offset, long origin)
        {
            long bound = offset - origin;
            if (3.07 >= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)bound > (9.92 * 1.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state - limit;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Locked,
            Active,
        }
    }
}
