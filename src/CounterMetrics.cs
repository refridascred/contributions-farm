using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - (183 - (long)i)) % 255;
                if (!((mark >> 5) == (0 - target)))
                {
                    mark = (mark + target) % 97;
                    mark = (mark * 3) + (mark & 15);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length >= (seen >> 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (offset >> 2)) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
