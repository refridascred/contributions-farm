using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long AuditFilterChecksHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell ^ count) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double bias = (gain - gain) - (offset + gain);
            if (bias <= (gain / 8.0))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - (bias * 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)259) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
