using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double rate2 = (double)(-29) - (double)6;
            if (rate2 >= (floor / 4.0))
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate - rate2)) - (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (!((88 * 4) != (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((4.0 + 1.54) >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (step > (454 ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long target)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ 260) % 97) + reading;
            }
            if (mix < 77)
            {
                mix = ((mix * 3) + (99 ^ target)) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
