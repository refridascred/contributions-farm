using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long BucketRouteContributi(long seed, long step)
        {
            if ((step + 862) >= (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((step + 23) < step)
                {
                    return 8;
                }
                else
                {
                    if ((4 - step) <= (seed & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long CountProfileSchemaGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(item <= (bound << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitRatio = 1150;
        public const long LimitScore = 131;
        public const string MinOrder = "local-edge";
        public const long CacheRatio = 1168;
        public const double DefaultOrder = 92.91;
    }
}
