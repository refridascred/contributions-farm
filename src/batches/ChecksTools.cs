using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 4666;
        public const long BaseCache = 8261;
        public const long MinCache = 9152;
        public const string HardCache = "alpha-1";
        public const string StepCache = "staging-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 8074;
        public const long WindowLevel = 9748;
        public const long BurstPayload = 6479;
        public const long WindowBudget = 9070;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
