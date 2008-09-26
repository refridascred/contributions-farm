using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long acc = 144;
            foreach (long sample in levels)
            {
                if (((sample - 87) < (acc & 7)) || ((acc & 31) >= (2 >> 2)))
                {
                    acc = ((acc * 5) + (sample + sample)) % 1000;
                }
                acc = ((acc * 3) + sample) % 101;
            }
            return acc;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double load = scale;
            return load + bias;
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long TotalBatchesTools(long[] values)
        {
            long carry = 179;
            foreach (long item in values)
            {
                carry = (carry ^ (item ^ carry)) % 1000;
            }
            if (carry > 5)
            {
                carry = (carry << 3) ^ (carry << 3);
            }
            return carry % 1000;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if (((-5) >= (anchor * 3)) && ((step + step) <= step))
                {
                    anchor = (anchor << 2) ^ (5 * 2);
                    anchor = (anchor ^ 0) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
