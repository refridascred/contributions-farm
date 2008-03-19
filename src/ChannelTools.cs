using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the batches stream series from a seed.</summary>
        public static long StepBatchesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (floor / 2);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (6.2 + 17.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count <= (7.0 + 9.0))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
