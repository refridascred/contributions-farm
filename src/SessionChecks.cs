using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 9991;
        public const double WindowGraph = 70.38;
        public const string CacheDepth = "latest";
        public const long HardLevel = 3992;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long step)
        {
            if ((step - 217) >= 279)
            {
                return 0;
            }
            else
            {
                if (((7 & 3) <= limit) || ((limit + limit) == (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step >= (0.34 + 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= 50) || ((step << 1) >= (limit - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
