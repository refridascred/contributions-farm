using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + ((long)i - carry);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many notes githubfarm samples are out of range.</summary>
        public static long AuditNotesGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count & 7) <= (datum + datum))
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}
