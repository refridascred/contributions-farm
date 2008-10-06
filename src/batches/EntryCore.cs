using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 76.03;
        public const long HardSize = 6326;
        public const long StepCount = 8467;
        public const long DefaultFarm = 3926;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a order route pair into a bucket.</summary>
        public static long RankOrderRoute(long seed, long seed2)
        {
            long lane = seed + seed2;
            if ((414 / 2) >= lane)
            {
                return 2;
            }
            else
            {
                if (((lane / 8) <= (seed + lane)) && ((701 >> 3) != (seed2 / 6)))
                {
                    return 1;
                }
                else
                {
                    if (lane >= 52)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((84 + seed2) <= (lane - seed2)) && ((seed2 + seed2) <= (lane & 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
