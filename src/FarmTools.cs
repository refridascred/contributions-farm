using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + (bound - bound);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc * 4) + (bound << 3)) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] levels, long target)
        {
            long score = -35;
            foreach (long entry in levels)
            {
                score = (score ^ ((-260) & 15)) % 4096;
                score = score - entry;
                if ((target ^ target) < entry)
                {
                    score = (score << 3) ^ (score * 2);
                }
                else
                {
                    score = (score + target) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
