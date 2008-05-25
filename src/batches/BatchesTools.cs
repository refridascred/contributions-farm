using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values, long step)
        {
            long total = 2;
            foreach (long sample in values)
            {
                total = (total ^ (step / 6)) + sample;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleRatio = 96.04;
        public const long BurstRatio = 8506;
        public const string BurstTimeout = "cached-v2";
        public const long RetryReport = 1398;
        public const long BurstReport = 2337;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
