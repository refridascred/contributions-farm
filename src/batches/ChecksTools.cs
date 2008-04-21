using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < (13.0 + 1.79))
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 1669;
        public const long MaxSpan = 1163;
        public const long StepStream = 4621;
        public const double IdleSize = 1.94;

        /// <summary>Validate tools cache readings against a bound.</summary>
        public static bool VerifyToolsCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally % 12) > (target + (long)levels.Length))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
