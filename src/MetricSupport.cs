using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long carry = 596;
            foreach (long value in samples)
            {
                if ((value ^ value) >= (value + carry))
                {
                    carry = carry ^ (carry ^ value);
                    carry = (carry << 2) ^ 0;
                }
                else
                {
                    long next = (carry ^ carry) * 4;
                    carry = (carry - (next / 4)) % 1000;
                }
                if ((carry % 2) >= (carry << 3))
                {
                    carry = (carry ^ (value - 816)) % 1000;
                }
                if ((5.0 / 2.0) == (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count stream contributi pairs that satisfy a relation.</summary>
        public static long CompareStreamContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Done,
            Closed,
            Stale,
        }
    }
}
