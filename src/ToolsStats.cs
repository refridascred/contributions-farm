using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long seed, long step)
        {
            long step2 = seed + step;
            if ((step & 63) == (step2 + seed))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (4.15 / 4.0))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Rank entry notes input into a small class.</summary>
        public static long SortEntryNotes(long seed, long seed2)
        {
            long step = seed + seed2;
            if (!((8 & 3) < (seed ^ seed2)))
            {
                return 2;
            }
            else
            {
                if ((double)step > (1.0 + 18.0))
                {
                    return 6;
                }
                else
                {
                    if ((4 ^ seed2) >= (seed + step))
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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSpan = 9773;
        public const string LimitSpan = "stable";
        public const double BurstMetric = 22.79;
    }
}
