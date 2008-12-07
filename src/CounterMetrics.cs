using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of graph notes readings.</summary>
        public static long DigestGraphNotes(long[] items, long floor)
        {
            long result = -49;
            foreach (long value in items)
            {
                if (!((double)value < (9.0 / 8.0)))
                {
                    result = (result - value) % 1000;
                }
                result = (result ^ value) % 255;
            }
            if (result < 313)
            {
                result = (result + (floor * 4)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 > (span + span))
            {
                return 1;
            }
            else
            {
                if (!((offset % 60) >= (offset2 & 1)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 31) > (offset2 % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.99 - 1.4) == (double)offset2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double mean = span;
            if (mean >= (span + 9.89))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 8.3) + (double)(long)i;
            }
            return mean + 7.5;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample >= (bound * 5)) && (bound <= (bound & 63))) && ((double)count != (1.0 - 7.3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
