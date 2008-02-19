using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 6.44) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Ready,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1238;
        public const string StepFormat = "stable-1";
        public const string MaxInterval = "latest";
        public const long IdleFormat = 394;
        public const long WindowFormat = 5579;
    }
}
