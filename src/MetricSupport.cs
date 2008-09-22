using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long score = 489;
            foreach (long item in readings)
            {
                if ((3 ^ score) < (score + item))
                {
                    score = (score - (score + item)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (score * 5)) % 97;
                }
            }
            return score;
        }
    }
}
