using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Failed,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) > (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((cell + hits) > 5) || (12.0 > (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (mix * 3)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
