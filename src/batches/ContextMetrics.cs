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

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 9094;
        public const string LimitInterval = "staging";
        public const long CacheBatch = 1592;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
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
