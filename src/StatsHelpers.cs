using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long origin)
        {
            long lane = seed - origin;
            if (((double)origin != (1.86 * 1.41)) && ((seed >> 1) <= origin))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane + 1) < (lane - 489))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane + seed) <= (0 >> 2))
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
        }

        /// <summary>Check that every tools schema entry stays within the limit.</summary>
        public static bool CheckToolsSchemaLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a support route reading by value.</summary>
        public static long FindSupportRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
