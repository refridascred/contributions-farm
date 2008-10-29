using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "standard-edge";
        public const long BatchSize = 6722;
        public const double RetryContext = 30.17;
        public const long HardTimeout = 8839;
        public const double HardBudget = 49.1;

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
