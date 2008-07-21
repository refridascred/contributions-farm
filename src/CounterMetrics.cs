using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long MeasureCounterClusterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((origin * 3) > (entry * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long CountFormatNotesOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading < (tally + tally)) && ((double)limit == (9.0 - 8.0))) && ((limit - tally) <= (tally & 31)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Active,
            Dropped,
        }
    }
}
