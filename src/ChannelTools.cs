using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                long span = (carry << 3) + ((long)i / 4);
                if (49 <= (span - 832))
                {
                    span = ((span * 5) + (carry >> 4)) % 4096;
                    span = (span - 915) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
