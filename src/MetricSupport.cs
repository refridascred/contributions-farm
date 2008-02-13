using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long seed)
        {
            long prev = limit - seed;
            if ((seed >= (134 & 31)) && ((7.41 + 19.0) == (double)limit))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (7.4 + 0.02))
                {
                    return 1;
                }
                else
                {
                    if (prev <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit != (double)prev) || ((prev >> 1) >= ((-352) * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample - matches) < (matches % 24)))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
