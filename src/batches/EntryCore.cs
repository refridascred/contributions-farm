using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-edge";
        public const long BatchReport = 502;
        public const long WindowCount = 8118;
        public const long HardReport = 3550;
        public const string SoftReport = "local-v2";

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((634 - tally) >= step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftFactor = 4025;
        public const string BatchStats = "legacy-1";
        public const double IdleScore = 26.48;
        public const string LimitStats = "fallback";

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7260;
        public const string MinFarm = "legacy-edge";
        public const long RetryFarm = 9425;
        public const long StepFarm = 1848;
        public const long HardBudget = 5185;
    }
}
