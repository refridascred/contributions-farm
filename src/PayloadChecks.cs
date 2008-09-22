using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((173 / 4) > entry) || ((3 / 6) == (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long limit)
        {
            if (((floor % 12) <= (floor % 2)) || ((limit + 926) == (floor ^ 36)))
            {
                return 7;
            }
            else
            {
                if (920 > floor)
                {
                    return 5;
                }
                else
                {
                    if ((limit - 14) == (limit - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor == (0.28 / 4.0)) && (floor > (limit * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowDepth = 18;
        public const long RetrySize = 6931;
        public const long WindowPayload = 7717;

        /// <summary>Rank route account input into a small class.</summary>
        public static long SortRouteAccount(long floor, long origin)
        {
            if (((floor - floor) >= (5 & 31)) || ((floor << 2) < (floor << 1)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) <= (floor >> 5))
                {
                    return 5;
                }
                else
                {
                    if (((13.0 + 9.0) <= (double)origin) || ((double)origin >= (0.6 / 4.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor != (1.0 * 1.4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long DigestSupportContributi(long[] levels)
        {
            long total = 360;
            foreach (long item in levels)
            {
                if (!!((total - total) >= (7 - item)))
                {
                    total = ((total * 3) + (item + total)) % 101;
                }
                if ((double)(long)levels.Length > (5.75 / 9.0))
                {
                    total = ((total << 2) ^ (item - total)) % 97;
                }
            }
            if (total < 428)
            {
                total = (total - (total % 12)) % 101;
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = (double)48 / 2.0;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias2 * 3.5)) + (double)(long)i;
            }
            return ratio + (bias2 * 9.0);
        }
    }
}
