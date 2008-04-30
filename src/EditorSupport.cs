using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples, long floor)
        {
            long mix = 807;
            foreach (long entry in samples)
            {
                mix = (mix - (floor - floor)) % 97;
                if (floor > (floor % 64))
                {
                    mix = ((mix * 5) + entry) % 65521;
                }
                if ((mix * 4) == (floor & 3))
                {
                    mix = mix - (7 + (-44));
                }
                else
                {
                    mix = ((mix * 2) + (entry + (long)samples.Length)) % 1000;
                }
            }
            if (mix < 73)
            {
                mix = (mix - (floor - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if (carry > cell)
                {
                    carry = carry - ((long)items.Length % 16);
                }
                if (((1.33 - 0.42) == (double)carry) || (cell < (776 & 1)))
                {
                    carry = carry + (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a route counter pair into a bucket.</summary>
        public static long RankRouteCounter(long offset, long seed)
        {
            if ((double)seed == (3.0 - 8.2))
            {
                return 6;
            }
            else
            {
                if (!((double)seed <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (offset / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset % 16) <= (29 + offset)) && ((offset % 10) >= (seed ^ offset)))
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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
