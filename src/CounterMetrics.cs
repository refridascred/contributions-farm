using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first metric already entry that matches the target.</summary>
        public static long FindMetricAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long StepPayloadToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i - (long)i) >= bound)
                {
                    carry = carry - (carry ^ (long)i);
                    carry = (carry ^ (bound / 6)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
