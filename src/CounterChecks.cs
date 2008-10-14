using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels, long bound)
        {
            long result = 99;
            foreach (long reading in levels)
            {
                if ((bound - 263) <= (result ^ bound))
                {
                    result = (result + (bound ^ reading)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if (target < (target * 5))
            {
                return 1;
            }
            else
            {
                if (((2.0 / 4.0) < (double)target) || ((double)seed <= (0.7 + 3.0)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > 8.7)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed > (double)4)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 23.81;
        public const double SoftTimeout = 74.04;
        public const double BaseCount = 85.56;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Ready,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
