using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Ready,
            New,
            Stale,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((entry % 97) >= entry) || ((tally % 8) > entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9258;
        public const long HardQueue = 7553;
        public const long BaseRatio = 1864;
        public const long MaxQueue = 5566;
        public const double DefaultSize = 13.75;

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 34.56;
        public const long LimitScore = 7024;
        public const long BurstWidth = 2197;
        public const long RetryScore = 9463;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if (!((step ^ step) > step))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step + origin)) || ((-398) < step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ origin) >= (-925))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
