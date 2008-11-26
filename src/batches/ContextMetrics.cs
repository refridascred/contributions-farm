using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next payload context value from a seed.</summary>
        public static long RollPayloadContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 2) ^ ((long)i ^ total)) % 65521;
                total = (total ^ offset) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = (state - ((long)i << 2)) % 101;
                state = (state - 4) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state << 3) ^ (29 / 7)) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((5.71 + 5.2) == (double)(long)i)
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Stale,
            Dropped,
            Draft,
        }
    }
}
