using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6581;
        public const long WindowRatio = 5592;
        public const long IdleScore = 9521;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long target)
        {
            long prev = bound + target;
            if (!((329 << 1) <= prev))
            {
                return 5;
            }
            else
            {
                if (!((0 + target) != (target - prev)))
                {
                    return 4;
                }
                else
                {
                    if ((target - target) > (bound - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (9.0 < (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token notes readings against a rule.</summary>
        public static long CountTokenNotesHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum % 2) >= 138)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
