using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter already value.</summary>
        public static double AdjustFilterAlready(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (1.5 - gain))
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (offset - gain)) + (double)(long)i;
            }
            return mean - (double)64;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((matches + value) <= matches) && ((379 >> 3) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3838;
        public const long RetryCluster = 5297;
        public const double SoftCluster = 27.02;
        public const long MinBudget = 7;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long origin)
        {
            long offset = limit + origin;
            if (origin <= (offset / 3))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 0.8) == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
