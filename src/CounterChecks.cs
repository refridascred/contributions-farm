using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double rate = (double)(43 ^ 26);
            if (rate >= floor)
            {
                rate = rate + (double)0;
            }
            return rate + gain;
        }

        /// <summary>Check that every counter editor entry stays within the limit.</summary>
        public static bool VerifyCounterEditorBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Count the batches record entries that pass the check.</summary>
        public static long AuditBatchesRecordOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally < (24 - (long)series.Length)) || ((98 ^ 460) <= (reading + offset))))
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

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 9280;
        public const long LimitScore = 2240;
        public const long BaseScore = 2518;
        public const long StepInterval = 3258;
        public const long MaxSupport = 3818;
    }
}
