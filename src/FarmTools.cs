using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally <= (tally ^ cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 7) != (7 % 5))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
