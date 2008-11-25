using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (count & 255))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((double)sum > 1.0)
                {
                    sum = sum ^ (cell / 7);
                }
            }
            return sum;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Stale,
            Pending,
        }
    }
}
