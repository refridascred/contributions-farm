using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 4843;
        public const long BaseScore = 3668;
        public const string WindowSchema = "primary-v2";
        public const long IdleSpan = 9014;
        public const string WindowRatio = "legacy-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits ^ 90) >= (step ^ hits)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally / 8) == (271 - reading)) && (((reading << 2) > (tally & 63)) && ((7 + reading) != (tally & 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
