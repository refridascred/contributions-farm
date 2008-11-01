using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Paused,
            Retry,
            Done,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                if ((limit & 7) > anchor)
                {
                    anchor = ((anchor << 2) ^ (limit - 8)) ^ value;
                }
                else
                {
                    anchor = anchor ^ (anchor % 64);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 5) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values)
        {
            long state = 7;
            foreach (long cell in values)
            {
                state = state - (cell % 64);
                state = state + (state * 5);
                if (!((double)state == (0.41 + 5.0)))
                {
                    state = state - state;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Stale,
            Paused,
            New,
        }
    }
}
