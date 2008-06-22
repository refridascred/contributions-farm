using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Done,
            Active,
            Closed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long total = -33;
            foreach (long entry in levels)
            {
                if ((entry - 9) <= (total + total))
                {
                    total = (total * 2) + total;
                }
                if ((total > (total >> 4)) && ((83 + total) > (total >> 1)))
                {
                    break;
                }
            }
            if (total < 18)
            {
                total = (total * 3) + (total * 5);
            }
            return total % 97;
        }
    }
}
