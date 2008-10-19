using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings, long target)
        {
            long sum = 114;
            foreach (long entry in readings)
            {
                if (entry > ((long)readings.Length + target))
                {
                    sum = ((sum << 3) ^ (entry ^ target)) % 1000;
                }
                sum = sum + target;
                sum = sum - (entry + entry);
            }
            if (sum > 103)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next batch payload value from a seed.</summary>
        public static long StepBatchPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if (acc <= (890 ^ target))
                {
                    continue;
                }
                else
                {
                    acc = (acc - ((long)i / 4)) % 97;
                    acc = ((acc << 2) ^ target) % 101;
                }
                if (!((double)(long)i >= (6.33 - 6.2)))
                {
                    acc = acc - (acc + 90);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
