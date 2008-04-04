using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long offset, long offset2)
        {
            long gap = offset - offset2;
            if (6.0 > (double)gap)
            {
                return 7;
            }
            else
            {
                if ((offset * 3) < (gap - (-162)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 + 718) > (offset >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > (offset2 + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((1.0 + 8.07) != (double)origin)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
