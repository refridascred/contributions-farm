using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long limit)
        {
            long sum = 774;
            foreach (long entry in series)
            {
                sum = (((sum << 3) ^ (sum - limit)) % 97) - entry;
                sum = sum ^ 75;
                if ((limit << 1) < (limit - 809))
                {
                    sum = sum ^ (limit % 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length ^ reading) >= (offset - offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
