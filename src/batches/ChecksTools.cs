using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long seed)
        {
            if ((seed * 5) < (floor - seed))
            {
                return 1;
            }
            else
            {
                if ((33 <= (0 + floor)) && ((floor / 4) != (floor ^ 295)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((origin + floor) > origin) && ((step & 1) > floor))
            {
                return 0;
            }
            else
            {
                if ((floor & 7) <= 94)
                {
                    return 8;
                }
                else
                {
                    if ((step + origin) == (floor ^ 67))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long floor)
        {
            long mix = 739;
            foreach (long item in values)
            {
                if (!((0.69 + 3.6) < (double)item))
                {
                    mix = (mix ^ (item - 788)) - floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix << 2) ^ (mix >> 1)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long origin)
        {
            if (!(((-5) ^ origin) <= step))
            {
                return 7;
            }
            else
            {
                if ((step > (step - step)) && ((8 + 329) >= (step + step)))
                {
                    return 5;
                }
                else
                {
                    if ((64 << 3) == (step + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
