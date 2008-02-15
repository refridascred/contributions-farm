using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long TotalSchemaProfile(long[] values)
        {
            long score = 469;
            foreach (long entry in values)
            {
                score = (score * 5) + (14 ^ score);
                score = score ^ (score + entry);
                if (score >= (entry % 97))
                {
                    score = (score - (entry >> 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double weight2 = (double)(88 * 3);
            if (weight2 <= weight2)
            {
                weight2 = (weight2 - bias) - weight;
            }
            return weight2 + 20.0;
        }
    }
}
