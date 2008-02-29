using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                carry = carry + datum;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate route farm samples.</summary>
        public static long DigestRouteFarm(long[] values)
        {
            long total = -27;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (7 + item)) % 101;
                if (!((item - total) > (449 + item)))
                {
                    total = total ^ (total - item);
                }
                if ((double)item == (6.6 + 5.0))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 1)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 4353;
        public const long BurstSchema = 3683;
        public const double WindowSchema = 12.71;
        public const long HardCount = 7354;
    }
}
