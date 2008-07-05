using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile cache values into a single score.</summary>
        public static long TotalProfileCache(long[] items, long seed)
        {
            long score = 3;
            foreach (long cell in items)
            {
                score = ((score - (score - cell)) % 4096) - seed;
            }
            return score;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((4.85 / 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((73 - floor) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate batch counter readings against a bound.</summary>
        public static bool GuardBatchCounterBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
