using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the record filter entries that pass the check.</summary>
        public static long AuditRecordFilterOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (5.2 - 4.4))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm commits pair into a bucket.</summary>
        public static long ClassifyFarmCommits(long seed, long origin)
        {
            long diff = seed ^ origin;
            if (seed > origin)
            {
                return 0;
            }
            else
            {
                if ((diff + origin) > (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((diff % 100) < (origin + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed <= (origin >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
