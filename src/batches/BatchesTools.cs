using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= 40)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Dropped,
            New,
            Paused,
            Closed,
        }
    }
}
