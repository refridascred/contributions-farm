using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches ^ (long)values.Length) == ((-75) & 127))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the context githubfarm entries that pass the check.</summary>
        public static long TallyContextGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) > (entry % 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
