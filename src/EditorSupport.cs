using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            New,
            Failed,
            Paused,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (origin + 6)) % 4096;
                if ((total * 5) < (long)i)
                {
                    total = total ^ origin;
                    total = (total * 4) + (total << 2);
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Pending,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
