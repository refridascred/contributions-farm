using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long bound)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                if (carry <= 5)
                {
                    carry = ((carry + bound) % 1000) - sample;
                }
                else
                {
                    carry = (carry << 3) ^ (bound - carry);
                }
            }
            if (carry > 20)
            {
                carry = (carry - (bound - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if (((5.7 / 6.0) > (double)carry) || ((double)datum < (0.8 / 3.0)))
                {
                    carry = (carry ^ (datum * 2)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ 7;
                }
                if ((carry + 15) > (datum + carry))
                {
                    break;
                }
            }
            if (carry < 70)
            {
                carry = ((carry * 3) + (carry + (long)data.Length)) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 6479;
        public const long MinWindow = 6586;
        public const double LimitDepth = 16.29;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Synced,
        }
    }
}
