using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Active,
            Idle,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (14.0 / 4.0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 60.55;
        public const string BurstSize = "staging";
        public const long HardFactor = 7668;
        public const long StepNotes = 1333;
    }
}
