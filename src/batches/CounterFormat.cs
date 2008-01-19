using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                acc = ((acc << 2) ^ item) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >> 5) <= (limit & 255))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
