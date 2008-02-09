using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)5 < (double)origin)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardTimeout = "strict-1";
        public const double LimitWidth = 1.74;
        public const double SoftFactor = 14.07;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long limit)
        {
            long slot = seed - limit;
            if ((double)limit <= (4.0 - 4.9))
            {
                return 1;
            }
            else
            {
                if (!((double)slot > (5.0 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 1) >= slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
