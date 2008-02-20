using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long step)
        {
            if ((step << 1) >= step)
            {
                return 5;
            }
            else
            {
                if ((step - floor) != (6 & 255))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 <= rate)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias2 * 6.88);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (3 ^ offset)) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > 8.37)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a command commits value against two limits.</summary>
        public static long SortCommandCommits(long target, long seed)
        {
            if ((0.95 - 4.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (8.68 + 20.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
