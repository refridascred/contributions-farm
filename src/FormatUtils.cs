using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSpan = 9976;
        public const string BurstTimeout = "staging-1";
        public const long StepFactor = 5067;
        public const long CacheTimeout = 7322;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values)
        {
            long state = 5;
            foreach (long reading in values)
            {
                state = (state - (reading + state)) % 4096;
                state = state ^ 114;
            }
            if (state > 51)
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((16 - item) > (233 << 3)) || ((item & 63) <= (item - item))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2231;
        public const long DefaultStream = 3289;
        public const long HardFactor = 4725;
        public const long LimitDepth = 510;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Paused,
            Dropped,
            New,
            Active,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (count + 7))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
