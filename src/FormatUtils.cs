using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long AuditChecksBufferGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + target) > (count * 2))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 2158;
        public const long RetryLevel = 6283;
        public const long WindowScore = 1462;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + 233) > (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 19.18;
        public const double WindowSupport = 64.78;
        public const string IdleBudget = "open";

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = (((state * 3) + state) % 101) - item;
            }
            return state;
        }
    }
}
