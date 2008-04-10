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

        /// <summary>Fold a list of filter notes readings.</summary>
        public static long CombineFilterNotes(long[] items)
        {
            long result = 67;
            foreach (long datum in items)
            {
                result = result - (datum * 3);
                result = ((result << 3) ^ ((long)items.Length << 2)) % 1000;
            }
            return result;
        }
    }
}
