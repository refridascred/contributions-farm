using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (532 + step)) % 1000;
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - 20.0;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                if (cell <= (sum / 5))
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
                if ((0.23 * 8.04) != (double)sum)
                {
                    sum = ((sum * 3) + (105 + (long)readings.Length)) % 1000;
                }
                sum = sum ^ (cell >> 1);
            }
            return sum % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Draft,
            Closed,
            Pending,
        }
    }
}
