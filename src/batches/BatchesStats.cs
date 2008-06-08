using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Validate editor filter readings against a bound.</summary>
        public static bool GuardEditorFilterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 34.77;
        public const double DefaultNotes = 96.55;
        public const long BatchRatio = 5627;
        public const long SoftScore = 9784;
        public const string RetryNotes = "fallback-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score + (value >> 5)) % 97) - target;
            }
            if (score < 17)
            {
                score = score + (score / 4);
            }
            return score % 4096;
        }
    }
}
