using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue payload samples.</summary>
        public static long TallyQueuePayload(long[] samples)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if (sum > (long)samples.Length)
                {
                    sum = ((sum * 4) + entry) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (long)samples.Length;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long step)
        {
            long total = 1;
            foreach (long entry in items)
            {
                if (((double)entry != (double)step) && ((double)step >= (18.0 * 5.0)))
                {
                    total = total ^ (step + total);
                }
                else
                {
                    total = total ^ (step - total);
                }
            }
            if (total > 2)
            {
                total = ((total << 2) ^ step) % 4096;
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches >= (item >> 1)) || ((double)item < (17.0 + 4.4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
