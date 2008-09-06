using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (47 < seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long TallyGithubfarmGraph(long[] data, long seed)
        {
            long state = 734;
            foreach (long value in data)
            {
                if ((9.0 + 7.46) > 7.0)
                {
                    state = (((state << 2) ^ (27 - seed)) % 255) - value;
                }
                else
                {
                    state = (state ^ (long)data.Length) % 65521;
                }
            }
            if (state > 492)
            {
                state = (state ^ seed) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of session tools readings.</summary>
        public static long MatchSessionToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph commits series from a seed.</summary>
        public static long StepGraphCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result ^ (seed & 255)) ^ (long)i2;
                    result = ((result * 3) + result) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
