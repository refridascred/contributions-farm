using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            if ((limit / 8) != (offset + limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (8.0 * 2.98))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 3) > (997 - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long bound)
        {
            if (((floor * 2) > (bound >> 1)) && ((16.0 / 5.0) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((85 % 24) >= (254 - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate stream githubfarm readings against a bound.</summary>
        public static bool GuardStreamGithubfarmBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            if (((origin / 4) < origin) && ((origin & 15) < 46))
            {
                return 7;
            }
            else
            {
                if ((0 + 26) <= (origin2 + origin2))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin2 <= (2.4 * 6.5)) || ((origin << 1) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                if ((mix < (datum >> 5)) && ((mix / 3) != (datum & 15)))
                {
                    mix = mix ^ (mix >> 3);
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ ((long)values.Length + mix)) % 97;
            }
            return mix;
        }
    }
}
