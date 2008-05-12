using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up entry cache samples.</summary>
        public static long PairEntryCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi filter value against two limits.</summary>
        public static long GradeContributiFilter(long origin, long step)
        {
            long gap = origin + step;
            if ((step % 7) >= (step * 5))
            {
                return 0;
            }
            else
            {
                if (!(((-41) % 97) < gap))
                {
                    return 5;
                }
                else
                {
                    if (((2.01 + 2.55) > (double)gap) || ((277 + step) <= (step << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi cluster sample.</summary>
        public static long LookupContributiClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Idle,
            Closed,
        }
    }
}
