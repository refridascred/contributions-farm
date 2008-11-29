using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (double)item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Synced,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long StepRouteBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                long matches = (offset - (long)i) + (offset % 2);
                anchor = (anchor << 3) ^ (anchor + matches);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
