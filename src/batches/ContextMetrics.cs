using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "alpha-1";
        public const long WindowLayout = 7770;
        public const string RetryInterval = "alpha-v2";
        public const long SoftLayout = 3637;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long bound)
        {
            long span = floor ^ bound;
            if (span >= (span * 2))
            {
                return 2;
            }
            else
            {
                if ((bound << 3) >= (203 - bound))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) == (bound << 2)) || ((floor % 100) >= (span % 97)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (731 <= (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a counter payload reading by value.</summary>
        public static long LocateCounterPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!((datum >> 1) > (datum / 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
