using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a stats token figure with a bias.</summary>
        public static double ProjectStatsToken(double weight, double bias)
        {
            double mean = 17.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - weight) - (double)(long)i) + bias;
            }
            return mean + weight;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long limit)
        {
            if (!((6.02 * 0.5) > (double)seed))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (seed > (limit & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
