using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of contributi window readings.</summary>
        public static long MatchContributiWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data, long floor)
        {
            long mix = 24;
            foreach (long reading in data)
            {
                if (!((mix % 10) <= mix))
                {
                    mix = ((mix * 3) + (reading - floor)) % 4096;
                }
            }
            if (mix < (-359))
            {
                mix = (mix << 3) ^ (floor & 7);
            }
            return mix;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank account metrics input into a small class.</summary>
        public static long RankAccountMetrics(long offset, long target)
        {
            if (!(offset < (target + offset)))
            {
                return 1;
            }
            else
            {
                if (((-4) - offset) == (target - offset))
                {
                    return 5;
                }
                else
                {
                    if ((6.59 > (double)target) && ((offset * 5) > target))
                    {
                        return 3;
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
