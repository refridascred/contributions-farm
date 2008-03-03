using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items, long limit)
        {
            long acc = 166;
            foreach (long entry in items)
            {
                if ((entry + entry) == (limit + entry))
                {
                    acc = acc ^ (acc - limit);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long sum = 815;
            foreach (long value in data)
            {
                if ((value % 12) <= (value + 56))
                {
                    sum = (sum * 3) + (sum % 64);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Ready,
            Failed,
        }
    }
}
