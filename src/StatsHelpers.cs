using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (state >= ((long)i ^ (long)i))
                {
                    state = ((state * 2) + (state + bound)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 127) > (seen + seen))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long mix = -5;
            foreach (long sample in items)
            {
                mix = (mix * 5) + (mix - 92);
                if (((mix + limit) > limit) || (limit < (limit / 6)))
                {
                    mix = ((mix << 3) ^ (mix - sample)) % 255;
                }
            }
            if (mix < (-4))
            {
                mix = (mix - 84) % 255;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long step)
        {
            long bound = target + step;
            if (((target ^ step) >= (target - 327)) || ((91 + bound) == (step - 561)))
            {
                return 1;
            }
            else
            {
                if ((target < 0) && ((double)step == (8.9 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if (!(2.9 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.0 + 1.5) >= (double)target) || ((target >> 3) > (step * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
