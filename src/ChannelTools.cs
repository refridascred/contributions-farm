using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 8794;
        public const string BatchDepth = "strict-1";
        public const double StepAlready = 72.25;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Pending,
            Closed,
        }
    }
}
