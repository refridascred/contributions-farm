using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long target)
        {
            long acc = 72;
            foreach (long item in samples)
            {
                acc = ((acc + (770 << 3)) + item) - target;
            }
            if (acc < 5)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 6.1;
        public const long StepCache = 2815;
        public const long IdleCache = 8157;

        /// <summary>Measure how many account entry samples are out of range.</summary>
        public static long AuditAccountEntryHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell - count) >= (count + count)) && ((double)cell <= (0.6 * 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            New,
            Locked,
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double bias = (double)(9 * 5);
            if (bias < (double)346)
            {
                bias = bias - (offset * 1.0);
            }
            return bias + ratio;
        }
    }
}
