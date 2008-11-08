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

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepRatio = 4.7;
        public const long BaseChecks = 3600;
        public const long SoftCount = 2749;
        public const long WindowChecks = 6831;

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

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values)
        {
            long mark = 89;
            foreach (long cell in values)
            {
                mark = mark ^ (mark ^ cell);
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7260;
        public const string MinFarm = "legacy-edge";
        public const long RetryFarm = 9425;
        public const long StepFarm = 1848;
        public const long HardBudget = 5185;
    }
}
