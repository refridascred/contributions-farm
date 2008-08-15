using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first buffer metric entry that matches the target.</summary>
        public static long LookupBufferMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((891 ^ lane) <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 2) != ((-94) & 127))
                {
                    return 1;
                }
                else
                {
                    if (bound > 3)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 5) >= lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ ((long)items.Length << 2)) % 1000) + cell;
            }
            return result;
        }
    }
}
