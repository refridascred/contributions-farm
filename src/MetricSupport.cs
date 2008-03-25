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

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long limit)
        {
            long prev = step ^ limit;
            if ((prev <= (prev / 3)) || ((3.3 * 1.5) == (double)prev))
            {
                return 4;
            }
            else
            {
                if (step >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((-933) >= (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
