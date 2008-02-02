using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((6 >= seen) || (((double)item >= 8.74) || ((seen + seen) == (limit * 5))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 25.34;
        public const long HardSpan = 9796;
        public const string WindowContext = "latest-1";
        public const long MinDepth = 6685;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            if (((bound / 6) <= bound) && (limit <= (bound >> 5)))
            {
                return 8;
            }
            else
            {
                if ((limit + bound) >= (bound & 7))
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
