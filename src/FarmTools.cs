using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            Done,
            Queued,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long limit, long seed)
        {
            if ((79 / 8) > (seed * 4))
            {
                return 6;
            }
            else
            {
                if (((limit ^ seed) < (limit ^ limit)) && (5.4 < (double)seed))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
