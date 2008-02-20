using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long sum = 0;
            foreach (long sample in items)
            {
                if (((origin / 7) < origin) && ((sample + origin) >= origin))
                {
                    sum = sum ^ (49 >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 9199;
        public const string BurstFactor = "open-1";
        public const long MinTimeout = 7049;
        public const long DefaultInterval = 3643;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long mark = 521;
            foreach (long datum in readings)
            {
                if ((datum + mark) > (datum * 4))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((mark - datum) <= mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
