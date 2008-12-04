using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(((hits << 3) >= hits) && ((9.28 + 20.0) != (double)(long)values.Length)))
                {
                    hits = ((hits + 1) + cell) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long floor)
        {
            if (((bound + bound) < floor) || ((bound >> 2) >= (479 + bound)))
            {
                return 6;
            }
            else
            {
                if (((bound * 2) > (floor >> 1)) && ((-230) > (floor + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((671 << 3) >= (floor & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i % 60) > (offset / 4))
                {
                    sum = (sum - (sum + offset)) % 255;
                    continue;
                }
                sum = (sum << 2) ^ (sum - sum);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum + ((long)i2 / 4)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
