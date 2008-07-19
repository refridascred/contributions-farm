using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxTimeout = 6792;
        public const long BatchEntry = 8988;
        public const long RetryInterval = 9463;
        public const string WindowBudget = "cached-1";

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long target)
        {
            if ((step & 15) >= ((-82) - 21))
            {
                return 3;
            }
            else
            {
                if ((step + target) < 32)
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (target + target)) || (target < (step ^ step)))
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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
