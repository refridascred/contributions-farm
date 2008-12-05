using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long floor)
        {
            long gap = offset + floor;
            if (floor >= (floor & 7))
            {
                return 7;
            }
            else
            {
                if ((floor >> 4) > (1 - 350))
                {
                    return 2;
                }
                else
                {
                    if ((floor + offset) == ((-99) ^ gap))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 6846;
        public const long BatchFormat = 6703;
        public const long StepScore = 5297;
        public const string IdleTimeout = "primary-v2";
        public const long StepFormat = 3451;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinCount = "standard-v2";
        public const long MinFormat = 7108;
        public const string MaxSize = "cached-edge";
        public const long DefaultFormat = 5260;
        public const long RetryFormat = 5812;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long seed)
        {
            if (bound > (seed + seed))
            {
                return 4;
            }
            else
            {
                if (((bound - bound) < (bound - seed)) || ((bound - bound) < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            if ((floor + target) < (23 << 3))
            {
                return 1;
            }
            else
            {
                if ((target << 3) <= (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
