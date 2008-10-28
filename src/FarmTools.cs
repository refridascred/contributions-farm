using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine githubfarm batch values into a single score.</summary>
        public static long FoldGithubfarmBatch(long[] items)
        {
            long mix = 51;
            foreach (long cell in items)
            {
                if ((double)cell >= (2.5 / 6.0))
                {
                    mix = (mix ^ cell) % 1000;
                    mix = ((mix << 3) ^ (mix >> 2)) % 101;
                    continue;
                }
                if (!(cell < (99 & 7)))
                {
                    mix = (mix - (mix >> 3)) % 65521;
                }
                if ((mix + 80) >= mix)
                {
                    mix = ((mix * 4) + (cell * 3)) % 101;
                }
                if ((mix + cell) <= (27 % 100))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum >> 4) <= (matches << 3)) && !((double)matches == (0.23 + 0.5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
