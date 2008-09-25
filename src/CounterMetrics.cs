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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = total + (limit * 2);
                total = (total - ((long)i - total)) % 1000;
                total = total ^ (long)i;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
