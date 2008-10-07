using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry ^ (carry / 3)) % 101;
                    carry = ((carry << 3) ^ ((long)i2 + carry)) % 65521;
                }
                carry = (carry ^ (carry >> 5)) % 65521;
                carry = carry - (carry / 4);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.0 * 1.51) >= (double)count)
                {
                    count = ((count + 3) + cell) + limit;
                }
            }
            return count;
        }
    }
}
