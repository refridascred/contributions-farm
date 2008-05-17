using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultBudget = "latest-v2";
        public const double CacheWidth = 25.2;
        public const string DefaultQueue = "open-1";

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long limit)
        {
            long bound = step ^ limit;
            if ((40 & 63) <= (step ^ bound))
            {
                return 8;
            }
            else
            {
                if (limit > (bound & 1))
                {
                    return 0;
                }
                else
                {
                    if ((step >= (-29)) && ((bound - limit) >= (step - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit / 5) <= (step + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
