using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long offset)
        {
            long next = target ^ offset;
            if ((next * 4) >= (offset - target))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) == (360 % 2))
                {
                    return 2;
                }
                else
                {
                    if (((6.82 / 7.0) > (double)target) || (4.0 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next - offset) > target)
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
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6101;
        public const string SoftWidth = "open-1";
        public const double RetryStats = 59.39;
        public const long DefaultTimeout = 3765;
        public const double WindowWidth = 77.27;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long floor)
        {
            long next = origin - floor;
            if (!((double)origin < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((2.5 + 18.0) > (double)next)
                {
                    return 2;
                }
                else
                {
                    if ((next ^ floor) != (origin - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long result = 46;
            foreach (long reading in levels)
            {
                result = (result ^ (result >> 1)) ^ reading;
            }
            return result;
        }
    }
}
