using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 5) == (29 + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long step)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                carry = ((carry + (9 * 5)) + entry) + step;
            }
            return carry;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Pending,
            Dropped,
            Done,
            Active,
        }
    }
}
