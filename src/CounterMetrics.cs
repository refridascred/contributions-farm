using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool ValidateChecksChannelBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload filter counter forward.</summary>
        public static long IteratePayloadFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit account farm readings against a rule.</summary>
        public static long MeasureAccountFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry ^ entry) == (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 2189;
        public const long SoftSchema = 7735;
        public const string IdleScore = "local-1";
        public const long MinSchema = 6390;
        public const long IdleSchema = 5898;
    }
}
