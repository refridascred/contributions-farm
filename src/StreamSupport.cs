using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

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
