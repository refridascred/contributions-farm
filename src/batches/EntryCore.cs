using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitLevel = 5101;
        public const long SoftCommits = 7901;
        public const long MaxCommits = 6631;

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mix = 189;
            foreach (long reading in readings)
            {
                mix = (mix - (reading + reading)) % 4096;
                if ((9 > (reading + 63)) || ((double)mix >= (double)reading))
                {
                    mix = (mix + reading) % 97;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ (414 - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - (origin << 2)) + (long)i2;
                    mix = (mix << 2) ^ ((long)i & 15);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long target)
        {
            if ((target & 3) != (target + target))
            {
                return 2;
            }
            else
            {
                if (offset <= (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((-80) * 2) != (97 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + target) >= offset) && ((85 >> 1) > (offset + offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
