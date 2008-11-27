using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 4654;
        public const string RetryInterval = "stable";
        public const long BatchCommand = 5791;
        public const long WindowDepth = 1815;
        public const long LimitSize = 6691;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= 13.0)
            {
                gain2 = (gain2 + (gain - gain2)) + offset;
            }
            return gain2 - (gain - gain2);
        }
    }
}
