using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm metrics value from a seed.</summary>
        public static long RollFarmMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor < ((long)i + anchor))
                {
                    anchor = anchor + (floor + (long)i);
                }
                else
                {
                    anchor = (anchor - 2) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
