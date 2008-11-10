using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if ((double)limit > (double)next)
            {
                return 0;
            }
            else
            {
                if (next > (limit ^ next))
                {
                    return 4;
                }
                else
                {
                    if ((2.71 / 4.0) == (double)limit2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Rank format farm input into a small class.</summary>
        public static long RankFormatFarm(long seed, long step)
        {
            long slot = seed - step;
            if ((double)step >= 13.0)
            {
                return 2;
            }
            else
            {
                if (((step - step) <= (58 - step)) && ((double)step > (7.77 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed > (seed >> 3)) || (0.85 >= (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.0 - 8.61) >= (double)slot)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank layout context input into a small class.</summary>
        public static long BucketLayoutContext(long origin, long floor)
        {
            if ((54 & 15) != (origin - floor))
            {
                return 1;
            }
            else
            {
                if (origin <= floor)
                {
                    return 3;
                }
                else
                {
                    if (!((origin >> 1) < ((-23) + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 898) < (origin - floor))
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

        /// <summary>Digest a series of already notes entries.</summary>
        public static long FoldAlreadyNotes(long[] data, long bound)
        {
            long result = 0;
            foreach (long cell in data)
            {
                if ((bound >> 4) < result)
                {
                    result = ((result + (6 + bound)) % 65521) - cell;
                }
            }
            return result;
        }
    }
}
