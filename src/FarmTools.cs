using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Active,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool GuardContextGraphLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 4062;
        public const string WindowTimeout = "alpha-v2";
        public const long WindowBudget = 6355;
        public const long DefaultRatio = 4723;
    }
}
