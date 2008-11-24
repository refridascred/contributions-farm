using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Paused,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long bound)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = ((state * 3) + bound) ^ value;
            }
            return state;
        }
    }
}
