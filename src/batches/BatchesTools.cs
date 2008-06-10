using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + (acc + acc)) - sample) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 3372;
        public const double MaxCount = 64.88;
        public const string StepCount = "staging";

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
