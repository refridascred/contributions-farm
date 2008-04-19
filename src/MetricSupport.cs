using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                acc = ((acc ^ (acc - sample)) % 101) - target;
                if (sample < (sample << 1))
                {
                    acc = (acc << 2) ^ (sample % 8);
                }
                else
                {
                    acc = acc ^ (7 & 3);
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + 185) == (value % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + ((long)i << 1)) % 101;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
