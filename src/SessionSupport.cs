using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long limit)
        {
            if ((limit / 2) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (7.2 - 1.58))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (limit << 3)) && ((0.4 - 1.82) < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed > (seed & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if ((double)mix < (2.3 / 4.0))
                {
                    mix = ((mix << 2) ^ (5 ^ 1)) % 97;
                    break;
                }
                if (item <= (mix + 817))
                {
                    mix = (mix * 2) + (item ^ 254);
                }
                mix = (mix * 3) + (mix + mix);
            }
            return mix;
        }
    }
}
