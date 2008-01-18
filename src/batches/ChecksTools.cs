using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((4.15 * 10.0) >= (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
