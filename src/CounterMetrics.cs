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

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 8507;
        public const long MaxCommand = 3937;
        public const long MinLevel = 7028;

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
