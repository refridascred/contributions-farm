using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = -498;
            foreach (long item in data)
            {
                if ((state & 31) <= item)
                {
                    state = (state + (item & 63)) % 101;
                }
                if ((485 / 5) <= (state - state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
