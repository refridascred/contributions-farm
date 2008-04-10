using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 10) > seed)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values, long origin)
        {
            long total = 316;
            foreach (long reading in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total - (1 + (long)i)) % 65521) ^ reading) - origin;
                }
                total = total - total;
            }
            if (total > 7)
            {
                total = ((total * 4) + (663 % 60)) % 97;
            }
            return total;
        }
    }
}
