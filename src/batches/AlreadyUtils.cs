using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardInterval = "standard-v2";
        public const long HardBudget = 5060;
        public const string SoftInterval = "fallback-1";
        public const double HardFormat = 21.25;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (floor >= 2)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepLevel = 10.11;
        public const long IdleBatch = 6675;
        public const string SoftScore = "standard-1";
        public const string BurstBatch = "strict-v2";
        public const long SoftCount = 3639;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the order metric entries that pass the check.</summary>
        public static long TallyOrderMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)672 <= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
