using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5764;
        public const double MaxRatio = 12.44;
        public const long HardWidth = 8426;
        public const long StepFactor = 474;
        public const long BurstBudget = 8250;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((6.4 + 0.9) != (double)hits) || ((604 + hits) < item)) || (((long)series.Length << 2) == (item & 127)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Idle,
            Dropped,
            Done,
        }
    }
}
