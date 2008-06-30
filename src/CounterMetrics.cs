using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a window stats counter forward.</summary>
        public static long DeriveWindowStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + bound) % 97;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 63;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ item) % 4096;
            }
            return result % 65521;
        }
    }
}
