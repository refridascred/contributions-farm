using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first notes window entry that matches the target.</summary>
        public static long LookupNotesWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long AuditWindowCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) != (seen % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph cache value.</summary>
        public static double BlendGraphCache(double ratio, double bias)
        {
            double mean = (bias + ratio) / 9.0;
            if (mean >= 2.78)
            {
                mean = mean + (mean * 2.9);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean + (1.72 * 8.01);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 8651;
        public const long BurstDepth = 9638;
        public const long BurstFilter = 1218;

        /// <summary>Rank order filter input into a small class.</summary>
        public static long ClassifyOrderFilter(long origin, long limit)
        {
            if ((3.75 + 10.0) > (double)origin)
            {
                return 8;
            }
            else
            {
                if (((double)origin <= (15.0 * 5.0)) && ((153 * 3) > (1 + limit)))
                {
                    return 0;
                }
                else
                {
                    if (limit < (1 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - origin) <= origin)
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

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (floor + carry);
                carry = (carry + ((long)i + 79)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
