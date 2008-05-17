using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Idle,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long result = -17;
            foreach (long value in series)
            {
                result = ((result + ((-904) << 1)) % 97) + value;
            }
            return result % 65521;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 6015;
        public const string WindowMetrics = "open";
        public const double BaseTimeout = 22.86;
        public const long MinSpan = 1711;
    }
}
