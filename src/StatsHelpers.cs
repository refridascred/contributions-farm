using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a window channel reading by value.</summary>
        public static long SeekWindowChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 70.17;
        public const double BurstFormat = 55.64;
        public const long CacheFormat = 7109;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Stale,
            Pending,
        }
    }
}
