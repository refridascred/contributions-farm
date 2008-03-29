using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next route order value from a seed.</summary>
        public static long RollRouteOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 3) ^ ((-3) + 209)) % 101;
                sum = ((sum << 2) ^ sum) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
