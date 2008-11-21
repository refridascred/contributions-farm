using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (double)0)
            {
                rate = (rate - offset) - ratio;
            }
            return rate - (double)9;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 7) >= (entry * 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
