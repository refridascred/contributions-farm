using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Audit entry githubfarm readings against a rule.</summary>
        public static long MeasureEntryGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits + hits) <= hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((origin & 63) > datum))
                {
                    result = (result - (result + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total + (total / 8)) % 101) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
