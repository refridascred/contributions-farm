using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long target)
        {
            long step2 = step + target;
            if (((target / 5) == (target >> 1)) || ((double)step2 > (7.0 * 4.33)))
            {
                return 8;
            }
            else
            {
                if (((step2 / 6) >= step2) || ((target / 5) < (step >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (step2 <= (step ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) > (step2 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long origin)
        {
            long step = seed - origin;
            if (seed >= (seed + origin))
            {
                return 1;
            }
            else
            {
                if (step > (step + (-231)))
                {
                    return 5;
                }
                else
                {
                    if ((4.0 * 18.0) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.95 - 6.72) > (double)origin)
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
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
