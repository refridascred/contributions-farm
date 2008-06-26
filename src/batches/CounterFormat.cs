using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a farm cluster pair into a bucket.</summary>
        public static long SortFarmCluster(long limit, long limit2)
        {
            if (491 > limit)
            {
                return 6;
            }
            else
            {
                if ((limit / 2) >= (168 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit2 >= (double)39)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((mix & 31) <= (mix >> 4))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((double)mix > (6.7 / 5.0))
                {
                    break;
                }
            }
            if (mix > (-79))
            {
                mix = (mix - (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many context tools samples are out of range.</summary>
        public static long AuditContextToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length <= (12.0 / 2.0))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
