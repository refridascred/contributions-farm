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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long score = 665;
            foreach (long item in readings)
            {
                score = ((((score * 3) + score) % 65521) + item) - bound;
            }
            return score % 1000;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
