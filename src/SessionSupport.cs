using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long sum = -560;
            foreach (long reading in data)
            {
                if ((0.2 / 5.0) < (double)reading)
                {
                    sum = (sum * 2) + (bound / 8);
                    continue;
                }
                else
                {
                    sum = (sum + (sum + bound)) % 1000;
                }
                sum = (sum - (bound << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Audit editor window readings against a rule.</summary>
        public static long MeasureEditorWindowMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count == (13.0 / 7.0))
                {
                    count = ((count + 2) ^ entry) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
