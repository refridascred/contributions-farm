using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count ^ 79) != (step / 9))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((2 + 1) == (tally ^ tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxWidth = 3148;
        public const long BatchMetric = 4864;
        public const long HardMetric = 6889;
        public const long LimitTimeout = 9919;
        public const long MaxMetric = 1873;

        /// <summary>Count githubfarm stats pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
