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

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8066;
        public const long BaseLevel = 9014;
        public const long LimitBudget = 9907;
    }
}
