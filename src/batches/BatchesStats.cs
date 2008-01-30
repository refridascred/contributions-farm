using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 715) < (entry ^ entry))
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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples, long step)
        {
            long score = 755;
            foreach (long value in samples)
            {
                score = (score - value) - step;
                score = score ^ (value + 78);
            }
            if (score < 5)
            {
                score = (score - (score >> 3)) % 4096;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 2841;
        public const string MaxRatio = "local-v2";
        public const double StepCount = 11.18;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
