using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series)
        {
            long mix = 50;
            foreach (long sample in series)
            {
                mix = (mix ^ (mix ^ sample)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Accumulate layout entry samples.</summary>
        public static long FoldLayoutEntry(long[] levels)
        {
            long anchor = 324;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (sample * 5)) % 4096;
                if ((5 / 8) != (73 - sample))
                {
                    anchor = anchor - (anchor % 8);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor & 63)) % 101;
                }
            }
            return anchor;
        }
    }
}
