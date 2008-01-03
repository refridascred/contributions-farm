using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 710;
        public const string BatchLevel = "primary-edge";
        public const double MinAlready = 44.31;
        public const long IdleAlready = 2390;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Synced,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (count << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
