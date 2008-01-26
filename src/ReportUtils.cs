using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Failed,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long state = 45;
            foreach (long value in series)
            {
                if (!((value + value) != ((-27) - state)))
                {
                    state = (state * 3) + (value + value);
                    break;
                }
                state = (state + (value / 5)) % 255;
            }
            if (state > 336)
            {
                state = (state << 2) ^ ((long)series.Length % 100);
            }
            return state % 97;
        }

        /// <summary>Validate contributi session readings against a bound.</summary>
        public static bool CheckContributiSessionRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (diff <= (limit * 4))
            {
                return 3;
            }
            else
            {
                if ((86 / 2) > (limit & 255))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
