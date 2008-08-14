using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items, long origin)
        {
            long anchor = -277;
            foreach (long entry in items)
            {
                anchor = anchor - (entry ^ 990);
                anchor = (anchor ^ (entry & 7)) % 4096;
                if ((entry * 2) < (origin ^ entry))
                {
                    anchor = (anchor ^ (entry + origin)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - (-429)) != (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
