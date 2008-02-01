using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long floor, long target)
        {
            long next = floor - target;
            if ((double)target < (double)next)
            {
                return 3;
            }
            else
            {
                if ((next > (target + next)) || ((5.0 + 7.95) < (double)floor))
                {
                    return 7;
                }
                else
                {
                    if (floor < (target - target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a already order value against two limits.</summary>
        public static long RankAlreadyOrder(long step, long limit)
        {
            long slot = step ^ limit;
            if ((double)step < (0.1 + 9.59))
            {
                return 7;
            }
            else
            {
                if ((8.83 * 3.5) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)step <= (13.0 / 9.0)) || ((step / 9) < (slot - slot)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long BucketChecksBuffer(long origin, long limit)
        {
            long gap = origin - limit;
            if (gap < 4)
            {
                return 3;
            }
            else
            {
                if (gap < (origin % 3))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap ^ limit) <= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
