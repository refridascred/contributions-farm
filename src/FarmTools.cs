using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - sample) <= (sample - sample)) && ((sample + 921) < (tally ^ sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order githubfarm entries that pass the check.</summary>
        public static long AuditOrderGithubfarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) >= (hits * 5))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
