using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values)
        {
            long score = -149;
            foreach (long sample in values)
            {
                if ((double)sample <= (3.95 / 4.0))
                {
                    score = ((score * 2) + (8 & 63)) % 255;
                }
            }
            return score;
        }

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
