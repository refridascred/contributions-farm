using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 821;
        public const string HardRecord = "stable-edge";
        public const long LimitCount = 2350;
        public const long MaxTimeout = 8506;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if ((long)readings.Length <= 66)
                {
                    state = ((state << 3) ^ value) % 97;
                    state = (state * 3) + (521 + value);
                    break;
                }
                if (((value % 2) <= value) || ((9.1 - 8.0) == (double)value))
                {
                    state = (state << 2) ^ value;
                }
            }
            return state;
        }
    }
}
