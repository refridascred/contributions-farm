using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + 3.4) + (double)(long)i) + rate;
            }
            return scale + (double)263;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits * 5) != (datum % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
