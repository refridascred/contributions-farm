using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((955 > ((-730) + datum)) || ((double)datum < 1.5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long FoldCommandBuffer(long[] series)
        {
            long score = 53;
            foreach (long datum in series)
            {
                score = (score ^ (10 + datum)) % 65521;
            }
            return score;
        }
    }
}
