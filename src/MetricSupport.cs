using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 218;
            foreach (long reading in series)
            {
                if ((reading + reading) < (961 + (-3)))
                {
                    continue;
                }
                acc = ((acc * 5) + (reading % 7)) % 255;
            }
            if (acc > 324)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
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
