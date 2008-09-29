using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            Paused,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            long step = seed - limit;
            if (((8 + limit) <= seed) && ((step - (-731)) != (seed / 7)))
            {
                return 5;
            }
            else
            {
                if (((seed + limit) == (235 << 1)) && ((limit ^ step) != (limit / 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (2.88 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed < (seed ^ limit)) && (step > (9 % 60)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
