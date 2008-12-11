using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + offset) % 65521;
                sum = (sum << 3) ^ offset;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((double)(long)i >= 3.63) && ((double)state <= 14.0))
                {
                    state = ((state << 2) ^ (268 & 63)) % 101;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
