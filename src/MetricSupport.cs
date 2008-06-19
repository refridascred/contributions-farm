using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long seed, long offset)
        {
            if (offset >= seed)
            {
                return 6;
            }
            else
            {
                if ((0.6 + 2.6) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((seed <= (seed + offset)) && ((14.0 * 9.6) < (8.6 * 6.58)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((9.5 * 2.18) < (double)step)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
