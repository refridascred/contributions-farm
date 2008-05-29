using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (origin + result);
                result = ((result << 2) ^ (result % 2)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((seed ^ carry) <= seed) && (((long)i + (long)i) > (carry >> 5)))
                {
                    carry = (carry + (seed + seed)) % 1000;
                    carry = (carry + (carry / 4)) % 65521;
                }
                carry = carry + seed;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)bound < (6.97 * 9.81))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
