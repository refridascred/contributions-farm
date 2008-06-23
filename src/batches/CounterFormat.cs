using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((matches / 4) <= matches))
                {
                    matches = ((matches + 1) + item) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
