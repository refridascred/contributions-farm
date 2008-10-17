using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long sum = 815;
            foreach (long reading in values)
            {
                if ((reading & 63) < (sum + sum))
                {
                    sum = (sum - (sum + 1)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
