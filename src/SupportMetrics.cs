using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long step)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + (step + cell);
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            if ((offset << 3) > (target + target))
            {
                return 8;
            }
            else
            {
                if (((double)target <= (double)0) || ((target << 1) != (target & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 2) <= (target - 947))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
