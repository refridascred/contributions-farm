using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long offset)
        {
            if ((2 << 3) == (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((bound - 0) == (bound * 5))
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) == (offset & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((tally + tally) != (487 + cell)) || ((2.0 + 8.19) > (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double ProjectBufferSchema(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)96)
            {
                bias3 = (bias3 - 2.9) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - 5.48) - (double)(long)i;
            }
            return bias3 + (double)(-37);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4512;
        public const long HardScore = 2819;
        public const long BurstChecks = 4537;
        public const long LimitChecks = 9886;
        public const long DefaultChecks = 9599;
    }
}
