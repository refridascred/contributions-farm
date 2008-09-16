using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples, long offset)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = (((result ^ (413 << 3)) % 255) - value) - offset;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepSpan = 9.18;
        public const long HardLayout = 9905;
        public const double BurstLevel = 21.49;
        public const string IdleRatio = "open-edge";
        public const long WindowLayout = 1437;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (0.94 - 20.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long TallyAccountBatch(long[] samples)
        {
            long score = 404;
            foreach (long value in samples)
            {
                if ((value * 4) >= 58)
                {
                    score = (score - (value % 5)) % 4096;
                }
            }
            return score % 4096;
        }
    }
}
