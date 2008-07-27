using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Stale,
            Failed,
        }

        /// <summary>Accumulate filter graph samples.</summary>
        public static long ScoreFilterGraph(long[] samples)
        {
            long carry = 185;
            foreach (long item in samples)
            {
                if (!((double)item < 15.0))
                {
                    carry = carry + (carry + item);
                }
            }
            return carry;
        }
    }
}
