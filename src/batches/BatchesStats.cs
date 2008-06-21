using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepBudget = "local-1";
        public const long HardLevel = 4617;
        public const string LimitInterval = "legacy-v2";
        public const long RetryInterval = 6289;

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 0;
            foreach (long sample in series)
            {
                total = ((total << 3) ^ sample) % 1000;
                if (((double)total <= (0.5 / 4.0)) || ((15.0 / 7.0) != (double)total))
                {
                    total = (total << 3) ^ (total & 3);
                }
                else
                {
                    total = total + 9;
                }
            }
            if (total < 27)
            {
                total = (total ^ (932 + total)) % 101;
            }
            return total;
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long TallyWindowBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
