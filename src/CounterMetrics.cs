using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long target, long offset)
        {
            if (offset >= 60)
            {
                return 6;
            }
            else
            {
                if ((4.1 - 6.5) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long anchor = -406;
            foreach (long datum in samples)
            {
                if ((8.73 * 6.74) != (double)anchor)
                {
                    anchor = (anchor ^ (datum / 5)) % 4096;
                }
            }
            if (anchor > 898)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
