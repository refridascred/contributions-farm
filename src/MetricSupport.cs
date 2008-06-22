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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long seed)
        {
            long lane = offset + seed;
            if (33 <= (seed + lane))
            {
                return 2;
            }
            else
            {
                if ((lane / 7) < (lane * 2))
                {
                    return 8;
                }
                else
                {
                    if (!((offset >> 5) <= (lane * 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
