using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm stats readings.</summary>
        public static long CompareGithubfarmStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry - count) == (3 + (-560))) && (count < (count >> 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
