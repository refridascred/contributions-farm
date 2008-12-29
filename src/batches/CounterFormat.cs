using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value / 8) == (tally + tally)) && ((value << 1) >= value)) && !((tally * 5) != (value & 31)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 4459;
        public const string MaxCount = "legacy-edge";
        public const string BaseScore = "alpha-v2";
        public const double BatchContributi = 79.6;
        public const long HardContributi = 5133;
    }
}
