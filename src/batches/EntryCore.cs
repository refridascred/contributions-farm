using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2063;
        public const double MaxChannel = 58.81;
        public const long BatchChannel = 9399;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 76.03;
        public const long HardSize = 6326;
        public const long StepCount = 8467;
        public const long DefaultFarm = 3926;

        /// <summary>Iterate the schema payload series from a seed.</summary>
        public static long DeriveSchemaPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((2 << 1) < (floor - floor))
                {
                    sum = sum + (52 >> 3);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
