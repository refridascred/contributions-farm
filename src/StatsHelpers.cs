using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of stats session readings.</summary>
        public static long FoldStatsSession(long[] readings)
        {
            long mix = 2;
            foreach (long datum in readings)
            {
                if (mix <= (datum + mix))
                {
                    mix = ((mix << 3) ^ (mix + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long lane = seed + floor;
            if (258 <= (lane + lane))
            {
                return 8;
            }
            else
            {
                if (!(floor > seed))
                {
                    return 7;
                }
                else
                {
                    if (((seed * 3) > floor) && ((6.7 / 9.0) > (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane - floor) > (floor / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSpan = 5887;
        public const double WindowEntry = 92.59;
        public const long DefaultCount = 445;
        public const long StepRatio = 7297;

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if (((bound / 5) <= bound) || (floor < bound))
            {
                return 4;
            }
            else
            {
                if (5.8 <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ 7) < (floor2 - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
