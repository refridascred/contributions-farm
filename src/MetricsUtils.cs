using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long state = -38;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (cell >> 5)) % 1000;
            }
            if (state > 129)
            {
                state = (state - (state & 31)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 79;
            foreach (long cell in values)
            {
                if (cell >= (carry - carry))
                {
                    carry = (carry ^ 6) % 65521;
                }
                else
                {
                    carry = carry + (8 ^ cell);
                }
                if ((carry % 5) < (cell - cell))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Closed,
            Ready,
            Locked,
            Paused,
        }
    }
}
