using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order context reading.</summary>
        public static double SmoothOrderContext(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (bias * 4.0)) - (double)(long)i) - span;
            }
            return bias + (double)(-634);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4876;
        public const double CacheTimeout = 68.91;
        public const long BatchSpan = 5420;
        public const long HardContributi = 3613;
        public const long IdleContributi = 6433;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Closed,
            Active,
        }

        /// <summary>Classify a batch already pair into a bucket.</summary>
        public static long SortBatchAlready(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((origin >> 4) != (prev + limit))
            {
                return 3;
            }
            else
            {
                if ((58 - prev) <= (limit >> 2))
                {
                    return 7;
                }
                else
                {
                    if (limit > (prev << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev * 3) >= prev)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor >> 5) <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((step / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((next % 64) <= (step + next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
