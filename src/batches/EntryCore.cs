using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a tools route pair into a bucket.</summary>
        public static long ClassifyToolsRoute(long target, long bound)
        {
            if ((bound >> 2) > (bound ^ target))
            {
                return 2;
            }
            else
            {
                if (!((0 + 282) <= (target + bound)))
                {
                    return 0;
                }
                else
                {
                    if (!((7.0 - 9.1) > (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = total + limit;
                if ((456 - (-670)) <= (total + 592))
                {
                    total = ((total << 2) ^ (limit - total)) % 4096;
                }
                total = ((total * 5) + total) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (((1.5 / 9.0) == (double)origin) && ((lane * 3) == (origin >> 1)))
            {
                return 3;
            }
            else
            {
                if ((5 >= (origin + origin)) && ((lane % 60) >= bound))
                {
                    return 1;
                }
                else
                {
                    if ((5.6 + 5.8) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound + (-712)) > (lane + origin)) || ((lane << 1) == (bound >> 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long target)
        {
            if (((1.46 * 9.87) < (double)step) && ((-27) > target))
            {
                return 3;
            }
            else
            {
                if ((2.55 + 6.52) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((step - target) < (target + step)) && (5 >= (step ^ 74)))
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
}
