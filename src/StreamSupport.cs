using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((floor << 2) <= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Pending,
            Locked,
        }
    }
}
