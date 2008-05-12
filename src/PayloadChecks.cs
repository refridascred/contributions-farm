using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)seed > 9.7)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long mark = 53;
            foreach (long sample in samples)
            {
                mark = ((mark << 2) ^ (sample * 4)) % 65521;
                if ((4.34 - 17.0) >= (double)sample)
                {
                    mark = ((mark << 3) ^ (sample * 4)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8916;
        public const double RetrySpan = 90.21;
        public const long SoftRatio = 929;
        public const long BurstSchema = 5174;
        public const long SoftSize = 8637;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (963 >> 5))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Ready,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
