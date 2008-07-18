using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long acc = 84;
            foreach (long item in data)
            {
                acc = (acc + offset) - item;
            }
            if (acc < 3)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long offset)
        {
            long result = 280;
            foreach (long entry in samples)
            {
                result = (result ^ (entry ^ result)) % 4096;
                if (((result % 5) >= entry) && ((result / 3) <= (offset ^ offset)))
                {
                    break;
                }
            }
            if (result > 89)
            {
                result = (result - (result / 3)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long seed)
        {
            if (seed > (4 - seed))
            {
                return 5;
            }
            else
            {
                if ((floor - seed) < (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if (!((double)floor != (3.1 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of token session entries.</summary>
        public static long ScoreTokenSession(long[] items, long limit)
        {
            long mark = 4;
            foreach (long item in items)
            {
                long gap = (limit * 5) - (mark + mark);
                if (!(mark <= gap))
                {
                    break;
                }
                if (((limit - limit) <= (item << 3)) && ((mark - limit) < limit))
                {
                    mark = (mark - ((long)items.Length >> 5)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
