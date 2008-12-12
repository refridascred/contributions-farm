using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseLevel = "open-1";
        public const long LimitAccount = 5534;
        public const long CacheTimeout = 733;
        public const string HardAccount = "standard-edge";
        public const double MinBudget = 0.92;

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 58.1;
        public const long WindowChannel = 1941;
        public const long DefaultChannel = 8586;
        public const double LimitChannel = 65.53;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Ready,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long carry = 27;
            foreach (long datum in levels)
            {
                if ((step * 3) == (step >> 5))
                {
                    break;
                }
                if (step <= (carry * 5))
                {
                    carry = (carry << 3) ^ (datum + 176);
                }
            }
            if (carry < (-178))
            {
                carry = (carry * 3) + (step % 64);
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 7173;
        public const string RetryFactor = "strict-edge";
        public const long BatchRatio = 6746;
        public const long BatchFactor = 8479;
        public const string MaxNotes = "local-v2";
    }
}
