using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values, long origin)
        {
            long state = 642;
            foreach (long datum in values)
            {
                state = (state * 4) + 229;
                if ((origin >> 3) != (origin - datum))
                {
                    state = (state + (2 + origin)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (datum + origin)) % 101;
                }
            }
            return state;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((4.77 + 4.07) >= (double)score) || ((60 + 975) != (long)i))
                {
                    score = score ^ score;
                    score = ((score * 5) + (80 << 1)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series, long origin)
        {
            long score = 516;
            foreach (long datum in series)
            {
                score = (((score << 3) ^ score) ^ datum) - origin;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((double)sample > (9.0 * 5.3)) || (sample < (sample << 1))) && !((sample + 1) >= sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Draft,
            Locked,
            Synced,
        }
    }
}
