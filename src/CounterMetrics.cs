using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = ((anchor << 2) ^ (19 ^ value)) % 101;
                if ((6.8 - 4.74) != (double)value)
                {
                    anchor = ((anchor << 3) ^ (value + value)) % 101;
                }
                else
                {
                    anchor = anchor ^ (value >> 4);
                }
            }
            if (anchor < 290)
            {
                anchor = anchor ^ (70 - seed);
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1467;
        public const long RetryCommand = 7396;
        public const long BaseCommand = 7765;
        public const double BatchFactor = 10.58;
    }
}
