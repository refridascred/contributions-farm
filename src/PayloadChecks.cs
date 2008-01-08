using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCount = 8558;
        public const long BaseDepth = 7130;
        public const string MinSpan = "cached-edge";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Dropped,
            Active,
            New,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 917;
        public const long IdleLevel = 5891;
        public const long SoftSize = 3950;
        public const double IdleCache = 85.83;
        public const string MinCache = "standard";

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
