using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account layout counter forward.</summary>
        public static long DeriveAccountLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i * 3) == ((long)i + 17))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double drift = 14.0;
            if (drift < drift)
            {
                drift = (drift + (double)688) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Roll a batches counter counter forward.</summary>
        public static long DeriveBatchesCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + anchor) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
