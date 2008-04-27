using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= bias)
            {
                drift = drift - (ratio * 8.0);
            }
            return drift + drift;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long origin)
        {
            long prev = limit - origin;
            if ((origin % 10) >= (limit - origin))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (12.0 * 2.5))
                {
                    return 3;
                }
                else
                {
                    if ((prev & 31) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin >= (37 + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
