using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Pending,
            New,
            Paused,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + tally) >= (tally ^ tally))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
