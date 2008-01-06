using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5989;
        public const string BaseLayout = "staging-edge";
        public const double BurstSize = 2.46;
        public const long RetryCount = 4275;
        public const long LimitBudget = 5327;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (step << 3);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 42.31;
        public const double LimitStats = 53.54;
        public const long SoftScore = 7338;
        public const long IdleCount = 5784;

        /// <summary>Look up the position of a report already sample.</summary>
        public static long LookupReportAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
