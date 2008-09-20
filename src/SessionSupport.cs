using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-431) + step) > (step - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "staging-edge";
        public const long IdleQueue = 4684;
        public const long BurstSpan = 4977;

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLevel = 51.75;
        public const double LimitBudget = 50.61;
        public const long BurstRatio = 8555;
        public const string HardLayout = "alpha-edge";
    }
}
