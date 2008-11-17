using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((score * 2) + score) + reading;
            }
            return score % 65521;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value == (11.0 - 3.4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
