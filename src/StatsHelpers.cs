using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long offset)
        {
            if (8 > (offset >> 4))
            {
                return 6;
            }
            else
            {
                if ((1.0 * 4.3) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (!((3.0 + 9.3) != (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = result - bound;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = (gain + gain) - offset;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight * 10.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
