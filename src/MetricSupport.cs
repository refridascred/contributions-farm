using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstLevel = 671;
        public const double StepFactor = 64.57;
        public const long BatchStream = 9639;

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
