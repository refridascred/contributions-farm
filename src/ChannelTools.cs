using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

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
