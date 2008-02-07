using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 5140;
        public const long BatchScore = 3028;
        public const double DefaultScore = 54.0;
        public const long IdleGraph = 2404;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Closed,
            Paused,
            Synced,
        }
    }
}
