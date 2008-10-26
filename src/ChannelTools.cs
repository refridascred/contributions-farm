using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "primary-v2";
        public const long HardAlready = 2737;
        public const string BaseAlready = "primary-1";
        public const long BurstFactor = 2707;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3368;
        public const string WindowRatio = "local-v2";
        public const long StepNotes = 9334;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
