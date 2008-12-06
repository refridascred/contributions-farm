using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long sum = 90;
            foreach (long entry in samples)
            {
                sum = ((sum - entry) % 65521) + seed;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series, long origin)
        {
            long score = 366;
            foreach (long reading in series)
            {
                if ((reading / 3) == (71 >> 5))
                {
                    score = (score + (reading ^ origin)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Idle,
            Closed,
            Done,
        }
    }
}
