using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a cache account counter forward.</summary>
        public static long StepCacheAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= (seed + (long)i))
                {
                    state = ((state << 3) ^ (seed & 127)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (seed - (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Locked,
            Idle,
            Done,
            Synced,
        }
    }
}
