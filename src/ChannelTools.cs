using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 2538;
        public const double SoftFilter = 68.02;
        public const string MaxFilter = "staging-1";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Closed,
            Stale,
            Paused,
        }
    }
}
