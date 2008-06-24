using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long AuditBatchAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits >= (10.0 - 4.5))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(57 <= ((long)i % 5)))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples)
        {
            long sum = 338;
            foreach (long datum in samples)
            {
                if (datum > sum)
                {
                    sum = (sum - (sum << 3)) % 97;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
