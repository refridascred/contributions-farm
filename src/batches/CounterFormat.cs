using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((9 % 8) != ((long)i - total))
                {
                    total = (total - (total << 2)) % 101;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
