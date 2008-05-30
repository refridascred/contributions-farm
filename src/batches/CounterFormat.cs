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

        /// <summary>Find the first payload contributi entry that matches the target.</summary>
        public static long LookupPayloadContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
