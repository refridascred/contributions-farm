using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 314;
            foreach (long sample in values)
            {
                score = score ^ sample;
                score = (score + (sample & 3)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine githubfarm graph values into a single score.</summary>
        public static long DigestGithubfarmGraph(long[] levels, long limit)
        {
            long state = 624;
            foreach (long sample in levels)
            {
                long span = (state - state) - (state + sample);
                if ((sample >> 1) >= (state + 5))
                {
                    state = state + span;
                }
                else
                {
                    span = span + (limit << 2);
                }
                if (!(((-1) / 3) != (limit ^ limit)))
                {
                    state = (state * 5) + (state / 6);
                }
            }
            if (state > 76)
            {
                state = ((state * 3) + (state + state)) % 4096;
            }
            return state % 1000;
        }
    }
}
