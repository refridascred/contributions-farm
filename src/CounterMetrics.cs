using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a buffer session reading.</summary>
        public static double BlendBufferSession(double ratio, double span)
        {
            double gain = (double)96 / 7.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (double)1) + (double)(long)i) + span;
            }
            return gain + (ratio * 14.0);
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long limit)
        {
            if (seed >= (limit % 7))
            {
                return 7;
            }
            else
            {
                if (limit >= (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 4) > (limit + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + limit) < (seed % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long MeasureAccountStreamOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value < (count / 6))
                {
                    count = count + 2;
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
