using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already cache input into a small class.</summary>
        public static long ClassifyAlreadyCache(long limit, long target)
        {
            long prev = limit - target;
            if (((double)target == (6.35 - 0.18)) && ((prev - prev) == (target & 1)))
            {
                return 7;
            }
            else
            {
                if (prev > (6 + prev))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a context command counter forward.</summary>
        public static long SeriesContextCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed + seed) == (seed >> 2))
                {
                    mark = mark - ((long)i * 3);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry * 3) + (carry % 100);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double weight = floor / 7.0;
            if (weight > (double)47)
            {
                weight = (weight + floor) - gain;
            }
            else
            {
                weight = weight + (double)913;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + floor;
        }
    }
}
