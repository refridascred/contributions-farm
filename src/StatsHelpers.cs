using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long target2)
        {
            long span = target ^ target2;
            if (!((18.0 / 3.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if ((span ^ target) == (target2 / 3))
                {
                    return 0;
                }
                else
                {
                    if (target2 <= (target + 17))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-101) ^ target) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double rate, double floor)
        {
            double scale = rate + rate;
            if (scale >= (double)183)
            {
                scale = (scale + rate) + floor;
            }
            else
            {
                scale = scale + (double)86;
            }
            return scale - (0.9 - scale);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheLevel = 9519;
        public const string BaseCommand = "local";
        public const long SoftCommand = 4399;

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels, long offset)
        {
            long acc = 77;
            foreach (long cell in levels)
            {
                if (8.3 >= (double)offset)
                {
                    acc = (((acc * 3) + acc) % 4096) - cell;
                }
            }
            return acc;
        }
    }
}
