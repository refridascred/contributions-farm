using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ value) >= (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen > 893) && ((double)seen != (double)sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 9267;
        public const string MinTimeout = "primary-v2";
        public const long IdleCommand = 395;
    }
}
