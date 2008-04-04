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

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
