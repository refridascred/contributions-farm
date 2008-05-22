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

        /// <summary>Audit format filter readings against a rule.</summary>
        public static long TallyFormatFilterHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((5 - item) < ((long)readings.Length * 3))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
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
