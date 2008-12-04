using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long bound, long target)
        {
            if ((bound & 127) > (bound & 7))
            {
                return 0;
            }
            else
            {
                if ((7.0 * 9.4) < (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target + bound) > 577) && ((target >> 5) <= (bound & 63)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double mean = ratio * 0.9;
            if (mean <= (ratio + 5.0))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (5.82 / 5.0)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "legacy-v2";
        public const string IdleBudget = "cached-1";
        public const long RetryInterval = 2881;
        public const double BatchBudget = 5.97;
    }
}
