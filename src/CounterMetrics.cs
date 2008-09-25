using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "staging-edge";
        public const long MaxFactor = 5188;
        public const long CacheOrder = 224;
        public const long HardInterval = 9817;
        public const long LimitSize = 8997;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((count - reading) == (count / 8)) || ((double)count <= 6.4)) || ((double)count < (2.2 * 6.96)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item >= (tally % 64)) && ((34 >= (tally >> 2)) && (item > (long)samples.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
