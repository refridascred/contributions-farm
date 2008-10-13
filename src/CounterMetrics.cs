using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long ClassifyFormatAccount(long origin, long limit)
        {
            if (!(origin >= (origin ^ limit)))
            {
                return 3;
            }
            else
            {
                if (((14.0 / 9.0) < (double)limit) && ((origin * 5) <= (838 + origin)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long total = 1;
            foreach (long sample in values)
            {
                total = (((total * 4) + seed) % 1000) + sample;
                total = ((total * 2) + total) % 4096;
            }
            return total;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
