using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum % 7) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long carry = 7;
            foreach (long entry in items)
            {
                if ((entry & 255) <= (entry * 4))
                {
                    carry = (carry + (carry % 12)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (carry % 10);
                }
            }
            return carry % 4096;
        }
    }
}
