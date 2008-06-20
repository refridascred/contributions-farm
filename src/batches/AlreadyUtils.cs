using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 281;
            foreach (long value in items)
            {
                if ((mark + mark) >= (value + value))
                {
                    mark = (mark << 2) ^ (value + mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleWidth = 8170;
        public const string HardFormat = "alpha-edge";
        public const double MinFormat = 97.03;
        public const long HardInterval = 2653;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
