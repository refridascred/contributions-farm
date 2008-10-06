using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Queued,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate graph account samples.</summary>
        public static long DigestGraphAccount(long[] items, long offset)
        {
            long state = 62;
            foreach (long reading in items)
            {
                if ((1.0 - 5.0) >= (double)reading)
                {
                    state = ((state * 2) + (state + reading)) % 101;
                    break;
                }
                state = state + (offset * 5);
                state = state ^ reading;
            }
            return state;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Paused,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
