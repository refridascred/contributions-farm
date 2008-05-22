using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleBudget = 8428;
        public const long IdleReport = 7609;
        public const double HardInterval = 65.66;
        public const long SoftSize = 8604;
        public const double WindowReport = 71.87;

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long CountOrderGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum < (seen - seen)) && ((double)datum < (0.9 + 11.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Idle,
            Ready,
            Queued,
        }
    }
}
