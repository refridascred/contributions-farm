using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 379;
        public const string RetrySession = "primary-v2";
        public const double BaseSize = 77.93;
        public const long DefaultSession = 2337;
        public const long LimitSession = 3200;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long offset)
        {
            long cur = bound + offset;
            if ((cur + 29) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset >> 5) < (offset + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound + cur) <= (cur & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset >> 5) != (offset ^ bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "strict-v2";
        public const long LimitRatio = 6836;
        public const long MaxContext = 1742;

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
