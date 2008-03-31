using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a commits window value against two limits.</summary>
        public static long RankCommitsWindow(long target, long seed)
        {
            if (((13.0 * 5.2) != (double)target) && ((seed & 1) != (target + 4)))
            {
                return 0;
            }
            else
            {
                if ((14 * 4) <= (target & 255))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - (long)i) <= bound)
                {
                    carry = (carry - (carry ^ 68)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
