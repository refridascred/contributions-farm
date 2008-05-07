using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Paused,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double gain = (double)(229 & 1);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - gain) + (double)(long)i) + ratio) + span;
            }
            return gain - gain;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 202;
        public const long MaxSession = 5379;
        public const long HardDepth = 4999;
        public const string StepBudget = "cached-1";
    }
}
