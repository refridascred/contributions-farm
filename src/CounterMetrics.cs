using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series, long target)
        {
            long total = 651;
            foreach (long sample in series)
            {
                if ((double)sample != (double)607)
                {
                    total = (total + (total << 1)) + target;
                }
            }
            if (total < 409)
            {
                total = ((total << 3) ^ (total / 9)) % 97;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 86.64;
        public const double LimitDepth = 84.15;
        public const long MaxCount = 7139;
        public const string BatchSchema = "standard";
        public const double RetryTimeout = 23.95;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((-48) % 3) >= hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }
    }
}
