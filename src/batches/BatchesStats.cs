using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6805;
        public const double WindowQueue = 88.2;
        public const long MinQueue = 5996;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4 * 4) < (seen % 2))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
