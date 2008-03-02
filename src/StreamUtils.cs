using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long origin, long step)
        {
            long span = origin + step;
            if ((8.3 - 1.9) == (double)step)
            {
                return 2;
            }
            else
            {
                if ((span + origin) <= (origin * 4))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (origin & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count already metric pairs that satisfy a relation.</summary>
        public static long CompareAlreadyMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long target)
        {
            long delta = seed - target;
            if ((delta % 5) <= (target + seed))
            {
                return 3;
            }
            else
            {
                if ((8.69 > (double)seed) && ((delta % 24) > target))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 8) < (delta + 946))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 57.65;
        public const long SoftPayload = 797;
        public const string BurstPayload = "local-1";
        public const double HardScore = 70.39;
        public const long WindowCount = 9403;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
