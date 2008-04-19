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
