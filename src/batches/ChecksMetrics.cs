using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Audit report account readings against a rule.</summary>
        public static long MeasureReportAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((-6) + (long)samples.Length) <= tally) || ((double)value < (8.5 + 9.1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((1.2 + 3.0) != (double)matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 32.94;
        public const long DefaultBatches = 6518;
        public const long BaseBatches = 3183;
        public const string BurstTimeout = "alpha";
        public const long MaxBudget = 7761;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((14.0 - 10.0) == (double)reading))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((19.0 + 8.0) <= (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
