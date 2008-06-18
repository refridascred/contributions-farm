using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            New,
            Closed,
            Queued,
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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Closed,
            Pending,
            Dropped,
        }
    }
}
