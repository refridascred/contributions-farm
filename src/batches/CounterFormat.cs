using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 * 0.6) > (double)matches)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length <= hits) && ((hits + 9) > 47))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Dropped,
            Draft,
            New,
        }
    }
}
