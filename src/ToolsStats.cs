using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (((limit << 2) >= bound) || (9.0 >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((limit & 7) >= (limit % 97))
                {
                    return 2;
                }
                else
                {
                    if ((38 & 31) < (bound / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long AuditQueueSchemaHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((179 + seed) < 11) && ((16.0 / 8.0) < (double)reading)) || !(seed > (seen & 15)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "standard-edge";
        public const long HardDepth = 5292;
        public const long SoftGithubfarm = 199;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - 0) == (offset * 2))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double rate = (double)42 * 18.0;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias - gain)) + (double)(long)i;
            }
            return rate - (double)4;
        }
    }
}
