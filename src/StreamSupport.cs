using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit tools buffer readings against a rule.</summary>
        public static long CountToolsBufferOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((limit - 229) <= (limit + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Active,
            Failed,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long offset)
        {
            long sum = 983;
            foreach (long item in values)
            {
                if (sum >= (sum + item))
                {
                    sum = (sum + (8 + item)) % 1000;
                    sum = ((sum * 3) + (offset << 1)) % 1000;
                    break;
                }
                if (((512 & 3) < (8 ^ item)) && ((offset + 43) == (offset - item)))
                {
                    sum = sum + (item - offset);
                    sum = sum + (item - item);
                    continue;
                }
                if ((sum - (long)values.Length) <= sum)
                {
                    sum = ((sum * 4) + (offset + 6)) % 4096;
                }
            }
            if (sum < 15)
            {
                sum = (sum ^ (sum + (long)values.Length)) % 4096;
            }
            return sum % 1000;
        }
    }
}
