using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "standard-1";
        public const long BurstLayout = 4580;
        public const double StepLayout = 35.28;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
