using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long origin)
        {
            long prev = bound - origin;
            if (!((bound + origin) == (286 & 255)))
            {
                return 8;
            }
            else
            {
                if ((double)origin == (12.0 + 7.1))
                {
                    return 7;
                }
                else
                {
                    if ((bound & 127) < (bound - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - 0) <= (prev - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading >= (hits >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
