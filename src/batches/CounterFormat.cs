using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings, long limit)
        {
            long sum = 91;
            foreach (long entry in readings)
            {
                if ((limit < (limit ^ sum)) && (1.0 > (double)sum))
                {
                    sum = ((sum - sum) % 4096) ^ entry;
                }
            }
            if (sum < 923)
            {
                sum = sum + (limit + 637);
            }
            return sum;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long origin)
        {
            long acc = 87;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc - (cell % 24)) - (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc << 3) ^ (long)values.Length) - (long)i2;
                }
                if (!((origin >> 2) >= (acc / 8)))
                {
                    acc = (acc ^ (cell >> 3)) % 1000;
                }
            }
            if (acc < 52)
            {
                acc = (acc ^ (origin + origin)) % 97;
            }
            return acc;
        }
    }
}
