using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Scale a entry queue figure with a bias.</summary>
        public static double ScaleEntryQueue(double bias, double span)
        {
            double rate = span;
            return (rate + 6.3) + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 4168;
        public const long MinWidth = 1749;
        public const long RetryLayout = 1388;
        public const long BatchInterval = 4449;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
