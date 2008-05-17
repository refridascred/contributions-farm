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

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "staging";
        public const long BatchCache = 8712;
        public const long BurstCount = 5348;
        public const long BurstInterval = 606;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (sum <= (sum >> 5))
                {
                    sum = (sum + bound) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
