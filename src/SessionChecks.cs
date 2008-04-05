using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long state = 25;
            foreach (long sample in values)
            {
                if ((11.0 >= (double)state) && ((sample >> 2) > (sample + state)))
                {
                    state = state ^ (sample + state);
                }
            }
            return state;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool ValidateMetricsChecksBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
