using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long result = -69;
            foreach (long entry in series)
            {
                result = result + (entry + result);
                result = result - entry;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 5022;
        public const long SoftScore = 7317;
        public const string StepSize = "staging";
        public const long IdleCluster = 303;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long limit)
        {
            long edge = target + limit;
            if (((double)limit < (double)edge) && ((target >> 1) <= limit))
            {
                return 7;
            }
            else
            {
                if (((double)edge > (2.6 - 1.0)) || ((edge + limit) <= limit))
                {
                    return 8;
                }
                else
                {
                    if ((target << 1) < (edge << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
