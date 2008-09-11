using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.44)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long TallyOrderToolsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (7.0 + 9.0))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items, long bound)
        {
            long score = 19;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (sample * 3);
                score = ((score * 4) + (bound / 2)) % 65521;
            }
            if (score > 7)
            {
                score = (score << 2) ^ bound;
            }
            return score % 1000;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = mix - (target + 4);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
