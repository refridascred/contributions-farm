using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (floor > (-286))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long floor)
        {
            long anchor = 305;
            foreach (long item in samples)
            {
                if (971 < (floor ^ anchor))
                {
                    anchor = (anchor - (4 + floor)) + item;
                }
            }
            if (anchor < 37)
            {
                anchor = (anchor + (anchor * 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Active,
        }
    }
}
