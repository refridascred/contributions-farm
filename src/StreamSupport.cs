using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 2) ^ (carry & 7)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (seed > (item + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer batch readings.</summary>
        public static long CombineBufferBatch(long[] readings)
        {
            long score = 542;
            foreach (long value in readings)
            {
                score = (score - (-799)) % 1000;
                if ((score < (score + score)) && ((value + 328) <= value))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
