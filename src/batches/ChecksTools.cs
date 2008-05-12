using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 924;
            foreach (long item in series)
            {
                if ((sum < (sum * 5)) && (item >= (71 / 5)))
                {
                    sum = (sum + (item - sum)) % 255;
                }
            }
            return sum;
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
