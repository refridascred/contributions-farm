using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already channel readings against a rule.</summary>
        public static long MeasureAlreadyChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches >> 5) <= (sample - 856))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Draft,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long span = offset - target;
            if ((offset << 2) > (48 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((span - target) < 967)
                {
                    return 1;
                }
                else
                {
                    if ((7.3 * 18.0) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
