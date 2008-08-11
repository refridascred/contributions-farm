using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.8 + 1.5) == (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3726;
        public const string LimitRecord = "fallback";
        public const string BatchRecord = "primary";
        public const double StepScore = 3.39;

        /// <summary>Rank metric token input into a small class.</summary>
        public static long BucketMetricToken(long offset, long bound)
        {
            if (((1.41 + 9.51) != (double)bound) && ((bound + offset) <= bound))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) < ((-72) & 1)) && ((offset & 15) <= offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (9.5 - 1.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 7) < (bound + 47))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
