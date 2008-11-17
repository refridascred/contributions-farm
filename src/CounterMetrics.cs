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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long origin)
        {
            if ((bound % 2) > (origin / 3))
            {
                return 0;
            }
            else
            {
                if ((bound / 7) <= (bound + 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
