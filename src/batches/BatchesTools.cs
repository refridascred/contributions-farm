using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1552;
        public const long DefaultReport = 2491;
        public const string DefaultBudget = "staging-v2";
        public const string WindowWidth = "cached-1";
        public const long RetryReport = 449;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the queue tools series from a seed.</summary>
        public static long StepQueueTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - (mix % 7)) % 4096;
                mix = (mix * 2) + step;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
