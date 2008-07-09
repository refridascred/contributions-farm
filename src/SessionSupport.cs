using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long step)
        {
            long total = 8;
            foreach (long entry in items)
            {
                if ((9.2 - 3.0) > (double)entry)
                {
                    total = ((total - (entry + total)) % 97) + step;
                }
                else
                {
                    total = total - entry;
                }
            }
            if (total < 3)
            {
                total = (total * 5) + (total & 7);
            }
            return total;
        }

        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long ScoreMetricsChecks(long[] levels)
        {
            long sum = -1;
            foreach (long sample in levels)
            {
                sum = ((sum * 4) + (sum % 64)) % 4096;
                if ((5.08 + 0.1) != (double)sum)
                {
                    sum = ((sum * 5) + (sample * 3)) % 97;
                }
            }
            return sum % 1000;
        }
    }
}
