using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long target)
        {
            long cur = origin - target;
            if (target <= (target << 3))
            {
                return 2;
            }
            else
            {
                if (origin < (8 + cur))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout channel readings.</summary>
        public static long WeighLayoutChannel(long[] samples, long limit)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if ((result % 60) <= result)
                {
                    result = (((result ^ result) % 65521) - cell) + limit;
                }
            }
            return result;
        }
    }
}
