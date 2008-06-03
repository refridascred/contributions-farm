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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count >= (offset - 2))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
