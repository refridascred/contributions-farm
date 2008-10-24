using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((1.06 + 20.0) > (double)total))
                {
                    total = (total * 2) + (84 * 4);
                    total = (total * 4) + ((long)i - (long)i);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total << 3) ^ (offset ^ (-79))) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Idle,
            New,
            Paused,
        }
    }
}
