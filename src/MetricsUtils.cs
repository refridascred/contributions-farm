using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 27.37;
        public const string StepDepth = "alpha-edge";
        public const string BurstBudget = "local-edge";

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Failed,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 730;
            foreach (long cell in samples)
            {
                if (!((mix & 31) <= (90 % 64)))
                {
                    mix = ((mix << 2) ^ (cell + mix)) % 255;
                }
            }
            return mix;
        }
    }
}
