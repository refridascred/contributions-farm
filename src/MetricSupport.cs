using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (429 ^ reading)) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long TotalSchemaContext(long[] data)
        {
            long score = 10;
            foreach (long item in data)
            {
                if (item <= (score + item))
                {
                    score = (score ^ ((long)data.Length + score)) % 4096;
                }
                else
                {
                    score = (score ^ (long)data.Length) % 101;
                }
                if (!((11.0 + 2.35) >= (double)(long)data.Length))
                {
                    break;
                }
            }
            return score;
        }
    }
}
