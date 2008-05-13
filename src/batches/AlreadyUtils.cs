using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long mix = 62;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ origin;
                if (((18.0 + 8.0) == (double)entry) || ((-9) < mix))
                {
                    mix = ((mix * 4) + (3 / 3)) % 97;
                }
                else
                {
                    mix = (mix + (origin % 100)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long bound)
        {
            if (((bound + step) < (step + 5)) || (step <= (bound * 2)))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (8.29 * 8.0))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (18 + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((352 & 3) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account checks entry stays within the limit.</summary>
        public static bool CheckAccountChecksRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
