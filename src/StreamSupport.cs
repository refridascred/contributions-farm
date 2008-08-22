using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Queued,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5898;
        public const long DefaultRatio = 4320;
        public const long BatchLevel = 6906;
        public const long StepScore = 6866;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
