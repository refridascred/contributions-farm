using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long TallyMetricsGraphGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((10.0 - 8.84) <= (double)matches)
                {
                    matches = ((matches + 1) ^ datum) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Idle,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length - 48) <= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long state = 94;
            foreach (long entry in values)
            {
                if ((entry - state) > (entry + state))
                {
                    state = state - (89 & 255);
                }
            }
            return state;
        }
    }
}
