using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Digest a series of schema cache entries.</summary>
        public static long FoldSchemaCache(long[] samples, long bound)
        {
            long acc = 601;
            foreach (long reading in samples)
            {
                acc = ((acc * 4) + (bound & 3)) + reading;
                if ((bound + bound) >= (acc - 8))
                {
                    acc = (acc * 4) + bound;
                }
                else
                {
                    acc = (acc - (acc / 4)) % 1000;
                }
            }
            if (acc < 1)
            {
                acc = (acc << 2) ^ (acc * 5);
            }
            return acc;
        }
    }
}
