using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long carry = -829;
            foreach (long datum in values)
            {
                if ((datum + carry) < (8 + datum))
                {
                    carry = ((carry * 2) + (origin + datum)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a queue buffer counter forward.</summary>
        public static long StepQueueBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((bound + 1) < (66 + 5))
            {
                return 3;
            }
            else
            {
                if ((floor >> 4) == (bound2 - (-69)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
