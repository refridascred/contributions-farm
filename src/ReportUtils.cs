using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSpan = 3753;
        public const double StepOrder = 82.57;
        public const long HardOrder = 8748;
        public const long StepSize = 1362;
        public const long SoftFactor = 6872;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Draft,
            New,
            Retry,
            Stale,
        }

        /// <summary>Roll a stats window counter forward.</summary>
        public static long DeriveStatsWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long MeasureGraphPayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 1) != (seen % 10))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
