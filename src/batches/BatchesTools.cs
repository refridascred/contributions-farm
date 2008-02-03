using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum >> 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long ScoreChannelNotes(long[] levels)
        {
            long anchor = -514;
            foreach (long sample in levels)
            {
                if ((double)anchor == (double)sample)
                {
                    anchor = ((anchor << 2) ^ (67 & 31)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
            }
            if (anchor > (-2))
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Idle,
            Paused,
            Retry,
            Done,
        }
    }
}
