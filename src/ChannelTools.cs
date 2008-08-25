using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry % 100) != (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((9.62 / 7.0) == (double)limit))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
