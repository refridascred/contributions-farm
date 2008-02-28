using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long limit)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                state = (state - (limit % 12)) % 65521;
                if (2.3 <= (double)datum)
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 5) + (limit * 4)) % 101;
            }
            return state;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Pending,
            Stale,
        }
    }
}
