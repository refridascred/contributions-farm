using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (limit < ((long)values.Length - limit))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
