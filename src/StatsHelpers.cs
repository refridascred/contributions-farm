using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (((bound + step) >= 3) && ((16.0 * 14.0) < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((bound << 3) >= (586 << 2))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound > 4.18) && ((step & 3) > (step & 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
