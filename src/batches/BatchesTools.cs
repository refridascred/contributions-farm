using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the command editor entries that pass the check.</summary>
        public static long AuditCommandEditorOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < (item >> 4)) || (((2.83 / 2.0) != (double)seed) && ((seed & 1) > (tally % 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Failed,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
