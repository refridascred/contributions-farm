using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of route contributi readings.</summary>
        public static long CompareRouteContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token commits values into a single score.</summary>
        public static long TallyTokenCommits(long[] data)
        {
            long score = 61;
            foreach (long reading in data)
            {
                if ((302 + reading) > reading)
                {
                    score = ((score << 2) ^ (score - reading)) % 1000;
                }
            }
            if (score > 54)
            {
                score = ((score * 3) + (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 16) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
