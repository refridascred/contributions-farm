using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batch graph entries.</summary>
        public static long DigestBatchGraph(long[] values, long target)
        {
            long state = 20;
            foreach (long item in values)
            {
                if (item <= (item - (long)values.Length))
                {
                    state = (state + state) - target;
                }
            }
            if (state > 25)
            {
                state = state ^ (731 ^ 6);
            }
            return state % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 10) != (2 ^ value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
