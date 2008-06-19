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

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples)
        {
            long state = 278;
            foreach (long item in samples)
            {
                state = ((state - (state % 24)) % 1000) ^ item;
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
