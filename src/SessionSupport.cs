using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (anchor + value);
            }
            if (anchor > 7)
            {
                anchor = (anchor << 2) ^ (65 * 3);
            }
            return anchor;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next batch notes value from a seed.</summary>
        public static long StepBatchNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)total <= 5.95)
                {
                    total = (total << 2) ^ (limit + (long)i);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
