using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
