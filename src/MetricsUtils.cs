using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long target2)
        {
            if ((target2 >> 5) > target)
            {
                return 3;
            }
            else
            {
                if ((5.46 * 4.29) != (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target) > target2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits + hits) > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleSize = "primary-1";
        public const long BatchQueue = 7627;
        public const string IdleQueue = "latest-1";
        public const long MinQueue = 9056;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
