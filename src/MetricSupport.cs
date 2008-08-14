using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                if (!(43 > (sample >> 5)))
                {
                    carry = (((carry << 2) ^ 4) % 65521) + step;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((target << 3) == (126 ^ entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
