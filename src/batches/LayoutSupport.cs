using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of payload format entries.</summary>
        public static long DigestPayloadFormat(long[] levels)
        {
            long sum = 792;
            foreach (long cell in levels)
            {
                sum = (sum * 2) + (sum * 5);
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum << 2) ^ (sum & 1)) + (long)i;
                }
                if ((cell ^ sum) >= (-6))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 4096;
                }
                else
                {
                    sum = sum + (2 << 1);
                }
            }
            return sum;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((12.0 * 4.0) <= (double)seed)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Pending,
            Active,
            Queued,
            Done,
        }
    }
}
